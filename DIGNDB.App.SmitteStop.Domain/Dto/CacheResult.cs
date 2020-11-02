﻿using System.Collections.Generic;

namespace DIGNDB.App.SmitteStop.Domain.Dto
{
    public class CacheResult
    {
        public List<byte[]> FileBytesList { get; set; }
        public long Timestamp { get; }
        public bool NewerFilesExist { get; set; }
        public bool FinalForTheDay { get; set; }
        public bool CouldNotGetLock { get; set; }
    }
}
