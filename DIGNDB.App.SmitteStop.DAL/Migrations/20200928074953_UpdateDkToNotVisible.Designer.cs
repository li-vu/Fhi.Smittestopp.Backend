﻿// <auto-generated />
using System;
using DIGNDB.App.SmitteStop.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DIGNDB.App.SmitteStop.DAL.Migrations
{
    [DbContext(typeof(DigNDB_SmittestopContext))]
    [Migration("20200928074953_UpdateDkToNotVisible")]
    partial class UpdateDkToNotVisible
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DIGNDB.App.SmitteStop.Domain.Db.Country", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PullingFromGatewayEnabled")
                        .HasColumnType("bit");

                    b.Property<bool>("VisitedCountriesEnabled")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Country");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Code = "AT",
                            PullingFromGatewayEnabled = false,
                            VisitedCountriesEnabled = true
                        },
                        new
                        {
                            Id = 2L,
                            Code = "BE",
                            PullingFromGatewayEnabled = false,
                            VisitedCountriesEnabled = true
                        },
                        new
                        {
                            Id = 3L,
                            Code = "BG",
                            PullingFromGatewayEnabled = false,
                            VisitedCountriesEnabled = true
                        },
                        new
                        {
                            Id = 4L,
                            Code = "HR",
                            PullingFromGatewayEnabled = false,
                            VisitedCountriesEnabled = true
                        },
                        new
                        {
                            Id = 5L,
                            Code = "CY",
                            PullingFromGatewayEnabled = false,
                            VisitedCountriesEnabled = true
                        },
                        new
                        {
                            Id = 6L,
                            Code = "CZ",
                            PullingFromGatewayEnabled = false,
                            VisitedCountriesEnabled = true
                        },
                        new
                        {
                            Id = 8L,
                            Code = "EE",
                            PullingFromGatewayEnabled = false,
                            VisitedCountriesEnabled = true
                        },
                        new
                        {
                            Id = 9L,
                            Code = "FI",
                            PullingFromGatewayEnabled = false,
                            VisitedCountriesEnabled = true
                        },
                        new
                        {
                            Id = 10L,
                            Code = "FR",
                            PullingFromGatewayEnabled = false,
                            VisitedCountriesEnabled = true
                        },
                        new
                        {
                            Id = 11L,
                            Code = "DE",
                            PullingFromGatewayEnabled = false,
                            VisitedCountriesEnabled = true
                        },
                        new
                        {
                            Id = 12L,
                            Code = "GR",
                            PullingFromGatewayEnabled = false,
                            VisitedCountriesEnabled = true
                        },
                        new
                        {
                            Id = 13L,
                            Code = "HU",
                            PullingFromGatewayEnabled = false,
                            VisitedCountriesEnabled = true
                        },
                        new
                        {
                            Id = 14L,
                            Code = "IE",
                            PullingFromGatewayEnabled = false,
                            VisitedCountriesEnabled = true
                        },
                        new
                        {
                            Id = 15L,
                            Code = "IT",
                            PullingFromGatewayEnabled = false,
                            VisitedCountriesEnabled = true
                        },
                        new
                        {
                            Id = 16L,
                            Code = "LV",
                            PullingFromGatewayEnabled = false,
                            VisitedCountriesEnabled = true
                        },
                        new
                        {
                            Id = 17L,
                            Code = "LT",
                            PullingFromGatewayEnabled = false,
                            VisitedCountriesEnabled = true
                        },
                        new
                        {
                            Id = 18L,
                            Code = "LU",
                            PullingFromGatewayEnabled = false,
                            VisitedCountriesEnabled = true
                        },
                        new
                        {
                            Id = 19L,
                            Code = "MT",
                            PullingFromGatewayEnabled = false,
                            VisitedCountriesEnabled = true
                        },
                        new
                        {
                            Id = 20L,
                            Code = "NL",
                            PullingFromGatewayEnabled = false,
                            VisitedCountriesEnabled = true
                        },
                        new
                        {
                            Id = 21L,
                            Code = "PL",
                            PullingFromGatewayEnabled = false,
                            VisitedCountriesEnabled = true
                        },
                        new
                        {
                            Id = 22L,
                            Code = "PT",
                            PullingFromGatewayEnabled = false,
                            VisitedCountriesEnabled = true
                        },
                        new
                        {
                            Id = 23L,
                            Code = "RO",
                            PullingFromGatewayEnabled = false,
                            VisitedCountriesEnabled = true
                        },
                        new
                        {
                            Id = 24L,
                            Code = "SK",
                            PullingFromGatewayEnabled = false,
                            VisitedCountriesEnabled = true
                        },
                        new
                        {
                            Id = 25L,
                            Code = "SI",
                            PullingFromGatewayEnabled = false,
                            VisitedCountriesEnabled = true
                        },
                        new
                        {
                            Id = 26L,
                            Code = "ES",
                            PullingFromGatewayEnabled = false,
                            VisitedCountriesEnabled = true
                        },
                        new
                        {
                            Id = 27L,
                            Code = "SE",
                            PullingFromGatewayEnabled = false,
                            VisitedCountriesEnabled = true
                        },
                        new
                        {
                            Id = 7L,
                            Code = "DK",
                            PullingFromGatewayEnabled = false,
                            VisitedCountriesEnabled = false
                        },
                        new
                        {
                            Id = 28L,
                            Code = "EN",
                            PullingFromGatewayEnabled = false,
                            VisitedCountriesEnabled = false
                        });
                });

            modelBuilder.Entity("DIGNDB.App.SmitteStop.Domain.Db.Setting", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Setting");
                });

            modelBuilder.Entity("DIGNDB.App.SmitteStop.Domain.Db.TemporaryExposureKey", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime");

                    b.Property<int?>("DaysSinceOnsetOfSymptoms")
                        .HasColumnType("int");

                    b.Property<byte[]>("KeyData")
                        .IsRequired()
                        .HasColumnType("varbinary(255)")
                        .HasMaxLength(255);

                    b.Property<int>("KeySource")
                        .HasColumnType("int");

                    b.Property<long>("OriginId")
                        .HasColumnType("bigint");

                    b.Property<long>("RollingPeriod")
                        .HasColumnType("bigint");

                    b.Property<long>("RollingStartNumber")
                        .HasColumnType("bigint");

                    b.Property<int>("TransmissionRiskLevel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OriginId");

                    b.ToTable("TemporaryExposureKey");
                });

            modelBuilder.Entity("DIGNDB.App.SmitteStop.Domain.Db.TemporaryExposureKeyCountry", b =>
                {
                    b.Property<Guid>("TemporaryExposureKeyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("CountryId")
                        .HasColumnType("bigint");

                    b.HasKey("TemporaryExposureKeyId", "CountryId");

                    b.HasIndex("CountryId");

                    b.ToTable("TemporaryExposureKeyCountry");
                });

            modelBuilder.Entity("DIGNDB.App.SmitteStop.Domain.Db.Translation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("EntityId")
                        .HasColumnType("bigint");

                    b.Property<string>("EntityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EntityPropertyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("LanguageCountryId")
                        .HasColumnType("bigint");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LanguageCountryId");

                    b.ToTable("Translation");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            EntityId = 1L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInDanish",
                            LanguageCountryId = 7L,
                            Value = "Østrig"
                        },
                        new
                        {
                            Id = 2L,
                            EntityId = 2L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInDanish",
                            LanguageCountryId = 7L,
                            Value = "Belgien"
                        },
                        new
                        {
                            Id = 3L,
                            EntityId = 3L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInDanish",
                            LanguageCountryId = 7L,
                            Value = "Bulgarien"
                        },
                        new
                        {
                            Id = 4L,
                            EntityId = 4L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInDanish",
                            LanguageCountryId = 7L,
                            Value = "Kroatien"
                        },
                        new
                        {
                            Id = 5L,
                            EntityId = 5L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInDanish",
                            LanguageCountryId = 7L,
                            Value = "Cypern"
                        },
                        new
                        {
                            Id = 6L,
                            EntityId = 6L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInDanish",
                            LanguageCountryId = 7L,
                            Value = "Tjekkiet"
                        },
                        new
                        {
                            Id = 7L,
                            EntityId = 7L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInDanish",
                            LanguageCountryId = 7L,
                            Value = "Danmark"
                        },
                        new
                        {
                            Id = 8L,
                            EntityId = 8L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInDanish",
                            LanguageCountryId = 7L,
                            Value = "Estland"
                        },
                        new
                        {
                            Id = 9L,
                            EntityId = 9L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInDanish",
                            LanguageCountryId = 7L,
                            Value = "Finland"
                        },
                        new
                        {
                            Id = 10L,
                            EntityId = 10L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInDanish",
                            LanguageCountryId = 7L,
                            Value = "Frankrig"
                        },
                        new
                        {
                            Id = 11L,
                            EntityId = 11L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInDanish",
                            LanguageCountryId = 7L,
                            Value = "Tyskland"
                        },
                        new
                        {
                            Id = 12L,
                            EntityId = 12L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInDanish",
                            LanguageCountryId = 7L,
                            Value = "Grækenland"
                        },
                        new
                        {
                            Id = 13L,
                            EntityId = 13L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInDanish",
                            LanguageCountryId = 7L,
                            Value = "Ungarn"
                        },
                        new
                        {
                            Id = 14L,
                            EntityId = 14L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInDanish",
                            LanguageCountryId = 7L,
                            Value = "Irland"
                        },
                        new
                        {
                            Id = 15L,
                            EntityId = 15L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInDanish",
                            LanguageCountryId = 7L,
                            Value = "Italien"
                        },
                        new
                        {
                            Id = 16L,
                            EntityId = 16L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInDanish",
                            LanguageCountryId = 7L,
                            Value = "Letland"
                        },
                        new
                        {
                            Id = 17L,
                            EntityId = 17L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInDanish",
                            LanguageCountryId = 7L,
                            Value = "Litauen"
                        },
                        new
                        {
                            Id = 18L,
                            EntityId = 18L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInDanish",
                            LanguageCountryId = 7L,
                            Value = "Luxembourg"
                        },
                        new
                        {
                            Id = 19L,
                            EntityId = 19L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInDanish",
                            LanguageCountryId = 7L,
                            Value = "Malta"
                        },
                        new
                        {
                            Id = 20L,
                            EntityId = 20L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInDanish",
                            LanguageCountryId = 7L,
                            Value = "Holland"
                        },
                        new
                        {
                            Id = 21L,
                            EntityId = 21L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInDanish",
                            LanguageCountryId = 7L,
                            Value = "Polen"
                        },
                        new
                        {
                            Id = 22L,
                            EntityId = 22L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInDanish",
                            LanguageCountryId = 7L,
                            Value = "Portugal"
                        },
                        new
                        {
                            Id = 23L,
                            EntityId = 23L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInDanish",
                            LanguageCountryId = 7L,
                            Value = "Rumænien"
                        },
                        new
                        {
                            Id = 24L,
                            EntityId = 24L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInDanish",
                            LanguageCountryId = 7L,
                            Value = "Slovakiet"
                        },
                        new
                        {
                            Id = 25L,
                            EntityId = 25L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInDanish",
                            LanguageCountryId = 7L,
                            Value = "Slovenien"
                        },
                        new
                        {
                            Id = 26L,
                            EntityId = 26L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInDanish",
                            LanguageCountryId = 7L,
                            Value = "Spanien"
                        },
                        new
                        {
                            Id = 27L,
                            EntityId = 27L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInDanish",
                            LanguageCountryId = 7L,
                            Value = "Sverige"
                        },
                        new
                        {
                            Id = 28L,
                            EntityId = 1L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInEnglish",
                            LanguageCountryId = 28L,
                            Value = "Austria"
                        },
                        new
                        {
                            Id = 29L,
                            EntityId = 2L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInEnglish",
                            LanguageCountryId = 28L,
                            Value = "Belgium"
                        },
                        new
                        {
                            Id = 30L,
                            EntityId = 3L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInEnglish",
                            LanguageCountryId = 28L,
                            Value = "Bulgaria"
                        },
                        new
                        {
                            Id = 31L,
                            EntityId = 4L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInEnglish",
                            LanguageCountryId = 28L,
                            Value = "Croatia"
                        },
                        new
                        {
                            Id = 32L,
                            EntityId = 5L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInEnglish",
                            LanguageCountryId = 28L,
                            Value = "Cyprus"
                        },
                        new
                        {
                            Id = 33L,
                            EntityId = 6L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInEnglish",
                            LanguageCountryId = 28L,
                            Value = "Czech Republic"
                        },
                        new
                        {
                            Id = 34L,
                            EntityId = 7L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInEnglish",
                            LanguageCountryId = 28L,
                            Value = "Denmark"
                        },
                        new
                        {
                            Id = 35L,
                            EntityId = 8L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInEnglish",
                            LanguageCountryId = 28L,
                            Value = "Estonia"
                        },
                        new
                        {
                            Id = 36L,
                            EntityId = 9L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInEnglish",
                            LanguageCountryId = 28L,
                            Value = "Finland"
                        },
                        new
                        {
                            Id = 37L,
                            EntityId = 10L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInEnglish",
                            LanguageCountryId = 28L,
                            Value = "France"
                        },
                        new
                        {
                            Id = 38L,
                            EntityId = 11L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInEnglish",
                            LanguageCountryId = 28L,
                            Value = "Germany"
                        },
                        new
                        {
                            Id = 39L,
                            EntityId = 12L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInEnglish",
                            LanguageCountryId = 28L,
                            Value = "Greece"
                        },
                        new
                        {
                            Id = 40L,
                            EntityId = 13L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInEnglish",
                            LanguageCountryId = 28L,
                            Value = "Hungary"
                        },
                        new
                        {
                            Id = 41L,
                            EntityId = 14L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInEnglish",
                            LanguageCountryId = 28L,
                            Value = "Ireland"
                        },
                        new
                        {
                            Id = 42L,
                            EntityId = 15L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInEnglish",
                            LanguageCountryId = 28L,
                            Value = "Italy"
                        },
                        new
                        {
                            Id = 43L,
                            EntityId = 16L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInEnglish",
                            LanguageCountryId = 28L,
                            Value = "Latvia"
                        },
                        new
                        {
                            Id = 44L,
                            EntityId = 17L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInEnglish",
                            LanguageCountryId = 28L,
                            Value = "Lithuania"
                        },
                        new
                        {
                            Id = 45L,
                            EntityId = 18L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInEnglish",
                            LanguageCountryId = 28L,
                            Value = "Luxembourg"
                        },
                        new
                        {
                            Id = 46L,
                            EntityId = 19L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInEnglish",
                            LanguageCountryId = 28L,
                            Value = "Malta"
                        },
                        new
                        {
                            Id = 47L,
                            EntityId = 20L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInEnglish",
                            LanguageCountryId = 28L,
                            Value = "Netherlands"
                        },
                        new
                        {
                            Id = 48L,
                            EntityId = 21L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInEnglish",
                            LanguageCountryId = 28L,
                            Value = "Poland"
                        },
                        new
                        {
                            Id = 49L,
                            EntityId = 22L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInEnglish",
                            LanguageCountryId = 28L,
                            Value = "Portugal"
                        },
                        new
                        {
                            Id = 50L,
                            EntityId = 23L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInEnglish",
                            LanguageCountryId = 28L,
                            Value = "Romania"
                        },
                        new
                        {
                            Id = 51L,
                            EntityId = 24L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInEnglish",
                            LanguageCountryId = 28L,
                            Value = "Slovakia"
                        },
                        new
                        {
                            Id = 52L,
                            EntityId = 25L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInEnglish",
                            LanguageCountryId = 28L,
                            Value = "Slovenia"
                        },
                        new
                        {
                            Id = 53L,
                            EntityId = 26L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInEnglish",
                            LanguageCountryId = 28L,
                            Value = "Spain"
                        },
                        new
                        {
                            Id = 54L,
                            EntityId = 27L,
                            EntityName = "Country",
                            EntityPropertyName = "NameInEnglish",
                            LanguageCountryId = 28L,
                            Value = "Sweden"
                        });
                });

            modelBuilder.Entity("DIGNDB.App.SmitteStop.Domain.Db.TemporaryExposureKey", b =>
                {
                    b.HasOne("DIGNDB.App.SmitteStop.Domain.Db.Country", "Origin")
                        .WithMany()
                        .HasForeignKey("OriginId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("DIGNDB.App.SmitteStop.Domain.Db.TemporaryExposureKeyCountry", b =>
                {
                    b.HasOne("DIGNDB.App.SmitteStop.Domain.Db.Country", "Country")
                        .WithMany("TemporaryExposureKeyCountries")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DIGNDB.App.SmitteStop.Domain.Db.TemporaryExposureKey", "TemporaryExposureKey")
                        .WithMany("VisitedCountries")
                        .HasForeignKey("TemporaryExposureKeyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DIGNDB.App.SmitteStop.Domain.Db.Translation", b =>
                {
                    b.HasOne("DIGNDB.App.SmitteStop.Domain.Db.Country", "LanguageCountry")
                        .WithMany("EntityTranslations")
                        .HasForeignKey("LanguageCountryId");
                });
#pragma warning restore 612, 618
        }
    }
}
