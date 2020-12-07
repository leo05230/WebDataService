using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebDataService.Domain.Entities
{
	public partial class DataSetContext : DbContext
	{
		public DataSetContext()
		{
		}

		public DataSetContext(DbContextOptions<DataSetContext> options)
			: base(options)
		{
		}

		public virtual DbSet<CodeArea> CodeAreas { get; set; }
		public virtual DbSet<CodeLocation> CodeLocations { get; set; }
		public virtual DbSet<MetroFlowNumber> MetroFlowNumbers { get; set; }
		public virtual DbSet<WeatherDetail> WeatherDetails { get; set; }
		public virtual DbSet<WeatherMain> WeatherMains { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
				optionsBuilder.UseSqlServer("Data Source=192.168.80.23;Database=DataSet;user id=sa;password=86125275;");
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<CodeArea>(entity =>
			{
				entity.ToTable("CodeArea");

				entity.HasIndex(e => e.CodeLocation, "IX_CodeArea_CodeArea");

				entity.Property(e => e.Id)
					.HasMaxLength(10)
					.HasColumnName("ID")
					.HasComment("區域ID");

				entity.Property(e => e.CodeLocation)
					.IsRequired()
					.HasMaxLength(10)
					.HasComment("CodeLocation.ID");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(10)
					.HasComment("區域名稱");
			});

			modelBuilder.Entity<CodeLocation>(entity =>
			{
				entity.ToTable("CodeLocation");

				entity.Property(e => e.Id)
					.HasMaxLength(10)
					.HasColumnName("ID")
					.HasComment("縣市編號");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(10)
					.HasComment("縣市名稱");
			});

			modelBuilder.Entity<MetroFlowNumber>(entity =>
			{
				entity.HasKey(e => e.IndexNo);

				entity.ToTable("MetroFlowNumber");

				entity.Property(e => e.IndexNo).HasComment("自動編號");

				entity.Property(e => e.Inbound).HasComment("進站人數");

				entity.Property(e => e.Outbound).HasComment("出站人數");

				entity.Property(e => e.RecordDate)
					.HasColumnType("date")
					.HasComment("紀錄時間");

				entity.Property(e => e.Station)
					.IsRequired()
					.HasMaxLength(20)
					.HasComment("捷運站名稱");
			});

			modelBuilder.Entity<WeatherDetail>(entity =>
			{
				entity.HasKey(e => e.IndexNo);

				entity.ToTable("WeatherDetail");

				entity.Property(e => e.IndexNo).HasComment("自動編號");

				entity.Property(e => e.AreaId)
					.IsRequired()
					.HasMaxLength(10)
					.HasColumnName("AreaID")
					.HasComment("CodeArea.ID");

				entity.Property(e => e.BodyTemperature)
					.HasColumnType("decimal(4, 1)")
					.HasComment("體感溫度");

				entity.Property(e => e.Comfort)
					.IsRequired()
					.HasMaxLength(10)
					.HasComment("舒適度");

				entity.Property(e => e.ComfortIndex)
					.HasColumnType("decimal(4, 1)")
					.HasComment("舒適度指數");

				entity.Property(e => e.Detail)
					.IsRequired()
					.HasMaxLength(300)
					.HasComment("綜合描述");

				entity.Property(e => e.DewPoint)
					.HasColumnType("decimal(4, 1)")
					.HasComment("露點溫度");

				entity.Property(e => e.EndTime)
					.IsRequired()
					.HasMaxLength(4)
					.IsUnicode(false)
					.HasComment("結束時間(24H)");

				entity.Property(e => e.Humidity)
					.HasColumnType("decimal(4, 1)")
					.HasComment("濕度");

				entity.Property(e => e.MainNo).HasComment("WeatherMain.IndexNo");

				entity.Property(e => e.RainRatio)
					.HasColumnType("decimal(4, 1)")
					.HasComment("降雨機率");

				entity.Property(e => e.StartTime)
					.IsRequired()
					.HasMaxLength(4)
					.IsUnicode(false)
					.HasComment("開始時間(24H)");

				entity.Property(e => e.States)
					.IsRequired()
					.HasMaxLength(10)
					.HasComment("天氣狀態");

				entity.Property(e => e.Temperature)
					.HasColumnType("decimal(4, 1)")
					.HasComment("溫度");

				entity.Property(e => e.WindDirection)
					.IsRequired()
					.HasMaxLength(10)
					.HasColumnName("windDirection")
					.HasComment("風向");

				entity.Property(e => e.WindSpeed)
					.HasColumnType("decimal(4, 1)")
					.HasComment("風速");

				entity.HasOne(d => d.MainNoNavigation)
					.WithMany(p => p.WeatherDetails)
					.HasForeignKey(d => d.MainNo)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_WeatherDetail_WeatherMain");
			});

			modelBuilder.Entity<WeatherMain>(entity =>
			{
				entity.HasKey(e => e.IndexNo);

				entity.ToTable("WeatherMain");

				entity.HasIndex(e => e.LocationId, "IX_WeatherMain_AreaID");

				entity.Property(e => e.IndexNo).HasComment("自動編號");

				entity.Property(e => e.Ctime)
					.HasColumnType("datetime")
					.HasColumnName("CTime");

				entity.Property(e => e.Date)
					.HasColumnType("date")
					.HasComment("紀錄日期");

				entity.Property(e => e.LocationId)
					.IsRequired()
					.HasMaxLength(10)
					.HasColumnName("LocationID")
					.HasComment("CodeLocation.ID");

				entity.Property(e => e.ApiId)
					.IsRequired()
					.HasMaxLength(10)
					.HasColumnName("ApiID");
			});

			OnModelCreatingPartial(modelBuilder);
		}

		partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
	}
}
