﻿using DIGNDB.App.SmitteStop.DAL.Context;
using DIGNDB.App.SmitteStop.Domain;
using DIGNDB.App.SmitteStop.Domain.Db;
using DIGNDB.App.SmitteStop.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIGNDB.App.SmitteStop.DAL.Repositories
{
    public class TemporaryExposureKeyRepository : ITemporaryExposureKeyRepository
    {
        private DigNDB_SmittestopContext _dbContext;
        ICountryRepository _countryRepository;

        // constructor used for unit tests
        public TemporaryExposureKeyRepository(DigNDB_SmittestopContext dbContext, ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
            _dbContext = dbContext;
        }

        public async Task AddTemporaryExposureKey(TemporaryExposureKey temporaryExposureKey)
        {
            _dbContext.TemporaryExposureKey.Add(temporaryExposureKey);
            await _dbContext.SaveChangesAsync();
        }

        public async Task AddTemporaryExposureKeys(IList<TemporaryExposureKey> temporaryExposureKeys)
        {
            _dbContext.TemporaryExposureKey.AddRange(temporaryExposureKeys);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IList<TemporaryExposureKey>> GetAll()
        {
            return await _dbContext.TemporaryExposureKey.ToListAsync();
        }

        public async Task<IList<byte[]>> GetAllKeyData()
        {
            return await _dbContext.TemporaryExposureKey.Select(x => x.KeyData).ToListAsync();
        }

        public int GetCountOfKeysByUpladedDayAndSource(DateTime uploadDate, KeySource keySource)
        {
            return _dbContext.TemporaryExposureKey
                .Where(key => key.CreatedOn.Date.CompareTo(uploadDate.Date) == 0)
                .Where(key => key.KeySource == keySource)
                .Count();
        }

        public IList<TemporaryExposureKey> GetAllKeysNextBatch(int numberOfRecordsToSkip, int batchSize)
        {
            if (batchSize <= 0) throw new ArgumentException($"Incorrect argument batchSize= {batchSize}");

            var query = _dbContext.TemporaryExposureKey
                .OrderBy(c => c.CreatedOn)
                .Skip(numberOfRecordsToSkip)
                .Take(batchSize);
            return query.ToList();
        }

        public async Task<TemporaryExposureKey> GetById(Guid id)
        {
            return await _dbContext.TemporaryExposureKey.FirstOrDefaultAsync(x => x.Id == id);
        }

        public IList<TemporaryExposureKey> GetTemporaryExposureKeysWithDkOrigin(DateTime uploadedOn, int fetchTimeout)
        {
            Country dkCountry = _countryRepository.GetDenmarkCountry();
            if (fetchTimeout > 0)
            {
                _dbContext.Database.SetCommandTimeout(fetchTimeout);
            }
            return _dbContext.TemporaryExposureKey.Where(x => x.Origin == dkCountry && x.CreatedOn.Date.CompareTo(uploadedOn.Date) == 0).OrderBy(x => x.Id).ToList();
        }

        public IList<TemporaryExposureKey> GetDkTemporaryExposureKeysUploadedAfterTheDateForGatewayUpload(
            DateTime uploadedOnAndLater,
            int numberOfRecordToSkip,
            int maxCount,
            KeySource[] sources)
        {
            if (maxCount <= 0) throw new ArgumentException($"Incorrect argument maxCount= {maxCount}");

            var dkCountry = _countryRepository.GetDenmarkCountry();

            var query = _dbContext.TemporaryExposureKey
               .Include(k => k.Origin)
               .Where(k => k.Origin == dkCountry)
               .Where(k => k.CreatedOn >= uploadedOnAndLater)
               .Where(k => sources.Contains(k.KeySource))
               .OrderBy(c => c.CreatedOn)
                    .ThenBy(c => c.RollingStartNumber);

            return TakeNextBatch(query, numberOfRecordToSkip, maxCount).ToList();
        }

        public async Task<IList<TemporaryExposureKey>> GetNextBatchOfKeysWithRollingStartNumberThresholdAsync(long rollingStartNumberThreshold, int numberOfRecordsToSkip, int batchSize)
        {
            var query = _dbContext.TemporaryExposureKey
               .Include(k => k.Origin)
               .Where(k => k.RollingStartNumber > rollingStartNumberThreshold);

            query = query.OrderBy(c => c.CreatedOn);
            return await TakeNextBatch(query, numberOfRecordsToSkip, batchSize).ToListAsync();
        }

        #region Query based on CreatedOn
        public IList<TemporaryExposureKey> GetDkTemporaryExposureKeysForPeriodNextBatch(DateTime uploadedAfter, int numberOfRecordsToSkip, int batchSize)
        {
            if (batchSize <= 0) throw new ArgumentException($"Incorrect argument batchSize= {batchSize}");

            var query = CreateQueryForKeysUploadedAfterTheDate(uploadedAfter, SortOrder.ASC);
            var dkCountry = _countryRepository.GetDenmarkCountry();
            query = query.Where(x => x.Origin == dkCountry);
            return TakeNextBatch(query, numberOfRecordsToSkip, batchSize).ToList();
        }

        public IList<TemporaryExposureKey> GetAllTemporaryExposureKeysForPeriodNextBatch(DateTime uploadedAfter, int numberOfRecordsToSkip, int batchSize)
        {
            return GetAllTemporaryExposureKeysForPeriodNextBatchQuery(uploadedAfter, numberOfRecordsToSkip, batchSize).ToList();
        }

        public IQueryable<TemporaryExposureKey> GetAllTemporaryExposureKeysForPeriodNextBatchQuery(DateTime uploadedAfter, int numberOfRecordsToSkip, int batchSize)
        {
            if (batchSize <= 0) throw new ArgumentException($"Incorrect argument batchSize= {batchSize}");

            var query = CreateQueryForKeysUploadedAfterTheDate(uploadedAfter, SortOrder.ASC);
            return TakeNextBatch(query, numberOfRecordsToSkip, batchSize);
        }

        private IQueryable<TemporaryExposureKey> CreateQueryForKeysUploadedAfterTheDate(DateTime uploadedAfter, SortOrder sortOrder)
        {
            var query = _dbContext.TemporaryExposureKey
               .Include(k => k.Origin)
               .Where(k => k.CreatedOn > uploadedAfter);

            query = (sortOrder == SortOrder.ASC) ? query.OrderBy(c => c.CreatedOn) : query.OrderByDescending(c => c.CreatedOn);
            return query;
        }
        #endregion

        private IQueryable<TemporaryExposureKey> TakeNextBatch(IQueryable<TemporaryExposureKey> keys, int numberOfRecordsToSkip, int batchSize)
        {
            if (batchSize <= 0) throw new ArgumentException($"Incorrect argument batchSize= {batchSize}");

            return keys
                .Skip(numberOfRecordsToSkip)
                .Take(batchSize);
        }

        public void RemoveKeys(List<TemporaryExposureKey> keys)
        {
            _dbContext.RemoveRange(keys);
            _dbContext.SaveChanges();
        }

    }
}