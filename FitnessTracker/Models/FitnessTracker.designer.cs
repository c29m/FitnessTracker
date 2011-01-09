﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FitnessTracker.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="FitnessTracker")]
	public partial class FitnessTrackerDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertFitnessUser(FitnessUser instance);
    partial void UpdateFitnessUser(FitnessUser instance);
    partial void DeleteFitnessUser(FitnessUser instance);
    partial void InsertWorkoutRegimen(WorkoutRegimen instance);
    partial void UpdateWorkoutRegimen(WorkoutRegimen instance);
    partial void DeleteWorkoutRegimen(WorkoutRegimen instance);
    partial void InsertWorkout(Workout instance);
    partial void UpdateWorkout(Workout instance);
    partial void DeleteWorkout(Workout instance);
    partial void InsertExerciseType(ExerciseType instance);
    partial void UpdateExerciseType(ExerciseType instance);
    partial void DeleteExerciseType(ExerciseType instance);
    #endregion
		
		public FitnessTrackerDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["FitnessTrackerConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public FitnessTrackerDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FitnessTrackerDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FitnessTrackerDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FitnessTrackerDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<FitnessUser> FitnessUsers
		{
			get
			{
				return this.GetTable<FitnessUser>();
			}
		}
		
		public System.Data.Linq.Table<WorkoutRegimen> WorkoutRegimens
		{
			get
			{
				return this.GetTable<WorkoutRegimen>();
			}
		}
		
		public System.Data.Linq.Table<Workout> Workouts
		{
			get
			{
				return this.GetTable<Workout>();
			}
		}
		
		public System.Data.Linq.Table<ExerciseType> ExerciseTypes
		{
			get
			{
				return this.GetTable<ExerciseType>();
			}
		}
	}
	
	[Table(Name="dbo.FitnessUsers")]
	public partial class FitnessUser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _FitnessUserId;
		
		private string _UserName;
		
		private System.DateTime _DateCreated;
		
		private System.DateTime _DateLastVisited;
		
		private EntitySet<WorkoutRegimen> _WorkoutRegimens;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFitnessUserIdChanging(int value);
    partial void OnFitnessUserIdChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnDateCreatedChanging(System.DateTime value);
    partial void OnDateCreatedChanged();
    partial void OnDateLastVisitedChanging(System.DateTime value);
    partial void OnDateLastVisitedChanged();
    #endregion
		
		public FitnessUser()
		{
			this._WorkoutRegimens = new EntitySet<WorkoutRegimen>(new Action<WorkoutRegimen>(this.attach_WorkoutRegimens), new Action<WorkoutRegimen>(this.detach_WorkoutRegimens));
			OnCreated();
		}
		
		[Column(Storage="_FitnessUserId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int FitnessUserId
		{
			get
			{
				return this._FitnessUserId;
			}
			set
			{
				if ((this._FitnessUserId != value))
				{
					this.OnFitnessUserIdChanging(value);
					this.SendPropertyChanging();
					this._FitnessUserId = value;
					this.SendPropertyChanged("FitnessUserId");
					this.OnFitnessUserIdChanged();
				}
			}
		}
		
		[Column(Storage="_UserName", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[Column(Storage="_DateCreated", DbType="DateTime NOT NULL")]
		public System.DateTime DateCreated
		{
			get
			{
				return this._DateCreated;
			}
			set
			{
				if ((this._DateCreated != value))
				{
					this.OnDateCreatedChanging(value);
					this.SendPropertyChanging();
					this._DateCreated = value;
					this.SendPropertyChanged("DateCreated");
					this.OnDateCreatedChanged();
				}
			}
		}
		
		[Column(Storage="_DateLastVisited", DbType="DateTime NOT NULL")]
		public System.DateTime DateLastVisited
		{
			get
			{
				return this._DateLastVisited;
			}
			set
			{
				if ((this._DateLastVisited != value))
				{
					this.OnDateLastVisitedChanging(value);
					this.SendPropertyChanging();
					this._DateLastVisited = value;
					this.SendPropertyChanged("DateLastVisited");
					this.OnDateLastVisitedChanged();
				}
			}
		}
		
		[Association(Name="FitnessUser_WorkoutRegimen", Storage="_WorkoutRegimens", ThisKey="FitnessUserId", OtherKey="FitnessUserId")]
		public EntitySet<WorkoutRegimen> WorkoutRegimens
		{
			get
			{
				return this._WorkoutRegimens;
			}
			set
			{
				this._WorkoutRegimens.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_WorkoutRegimens(WorkoutRegimen entity)
		{
			this.SendPropertyChanging();
			entity.FitnessUser = this;
		}
		
		private void detach_WorkoutRegimens(WorkoutRegimen entity)
		{
			this.SendPropertyChanging();
			entity.FitnessUser = null;
		}
	}
	
	[Table(Name="dbo.WorkoutRegimens")]
	public partial class WorkoutRegimen : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _WorkoutRegimenId;
		
		private int _FitnessUserId;
		
		private int _ExerciseTypeId;
		
		private System.DateTime _StartDate;
		
		private int _NumWeeks;
		
		private int _DaysPerWeek;
		
		private double _StartingNumMiles;
		
		private System.Nullable<double> _FinishingNumMiles;
		
		private int _StartingTotalSeconds;
		
		private System.Nullable<int> _FinishingTotalSeconds;
		
		private EntitySet<Workout> _Workouts;
		
		private EntityRef<FitnessUser> _FitnessUser;
		
		private EntityRef<ExerciseType> _ExerciseType;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnWorkoutRegimenIdChanging(int value);
    partial void OnWorkoutRegimenIdChanged();
    partial void OnFitnessUserIdChanging(int value);
    partial void OnFitnessUserIdChanged();
    partial void OnExerciseTypeIdChanging(int value);
    partial void OnExerciseTypeIdChanged();
    partial void OnStartDateChanging(System.DateTime value);
    partial void OnStartDateChanged();
    partial void OnNumWeeksChanging(int value);
    partial void OnNumWeeksChanged();
    partial void OnDaysPerWeekChanging(int value);
    partial void OnDaysPerWeekChanged();
    partial void OnStartingNumMilesChanging(double value);
    partial void OnStartingNumMilesChanged();
    partial void OnFinishingNumMilesChanging(System.Nullable<double> value);
    partial void OnFinishingNumMilesChanged();
    partial void OnStartingTotalSecondsChanging(int value);
    partial void OnStartingTotalSecondsChanged();
    partial void OnFinishingTotalSecondsChanging(System.Nullable<int> value);
    partial void OnFinishingTotalSecondsChanged();
    #endregion
		
		public WorkoutRegimen()
		{
			this._Workouts = new EntitySet<Workout>(new Action<Workout>(this.attach_Workouts), new Action<Workout>(this.detach_Workouts));
			this._FitnessUser = default(EntityRef<FitnessUser>);
			this._ExerciseType = default(EntityRef<ExerciseType>);
			OnCreated();
		}
		
		[Column(Storage="_WorkoutRegimenId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int WorkoutRegimenId
		{
			get
			{
				return this._WorkoutRegimenId;
			}
			set
			{
				if ((this._WorkoutRegimenId != value))
				{
					this.OnWorkoutRegimenIdChanging(value);
					this.SendPropertyChanging();
					this._WorkoutRegimenId = value;
					this.SendPropertyChanged("WorkoutRegimenId");
					this.OnWorkoutRegimenIdChanged();
				}
			}
		}
		
		[Column(Storage="_FitnessUserId", DbType="Int NOT NULL")]
		public int FitnessUserId
		{
			get
			{
				return this._FitnessUserId;
			}
			set
			{
				if ((this._FitnessUserId != value))
				{
					if (this._FitnessUser.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnFitnessUserIdChanging(value);
					this.SendPropertyChanging();
					this._FitnessUserId = value;
					this.SendPropertyChanged("FitnessUserId");
					this.OnFitnessUserIdChanged();
				}
			}
		}
		
		[Column(Storage="_ExerciseTypeId", DbType="Int NOT NULL")]
		public int ExerciseTypeId
		{
			get
			{
				return this._ExerciseTypeId;
			}
			set
			{
				if ((this._ExerciseTypeId != value))
				{
					if (this._ExerciseType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnExerciseTypeIdChanging(value);
					this.SendPropertyChanging();
					this._ExerciseTypeId = value;
					this.SendPropertyChanged("ExerciseTypeId");
					this.OnExerciseTypeIdChanged();
				}
			}
		}
		
		[Column(Storage="_StartDate", DbType="DateTime NOT NULL")]
		public System.DateTime StartDate
		{
			get
			{
				return this._StartDate;
			}
			set
			{
				if ((this._StartDate != value))
				{
					this.OnStartDateChanging(value);
					this.SendPropertyChanging();
					this._StartDate = value;
					this.SendPropertyChanged("StartDate");
					this.OnStartDateChanged();
				}
			}
		}
		
		[Column(Storage="_NumWeeks", DbType="Int NOT NULL")]
		public int NumWeeks
		{
			get
			{
				return this._NumWeeks;
			}
			set
			{
				if ((this._NumWeeks != value))
				{
					this.OnNumWeeksChanging(value);
					this.SendPropertyChanging();
					this._NumWeeks = value;
					this.SendPropertyChanged("NumWeeks");
					this.OnNumWeeksChanged();
				}
			}
		}
		
		[Column(Storage="_DaysPerWeek", DbType="Int NOT NULL")]
		public int DaysPerWeek
		{
			get
			{
				return this._DaysPerWeek;
			}
			set
			{
				if ((this._DaysPerWeek != value))
				{
					this.OnDaysPerWeekChanging(value);
					this.SendPropertyChanging();
					this._DaysPerWeek = value;
					this.SendPropertyChanged("DaysPerWeek");
					this.OnDaysPerWeekChanged();
				}
			}
		}
		
		[Column(Storage="_StartingNumMiles", DbType="Float NOT NULL")]
		public double StartingNumMiles
		{
			get
			{
				return this._StartingNumMiles;
			}
			set
			{
				if ((this._StartingNumMiles != value))
				{
					this.OnStartingNumMilesChanging(value);
					this.SendPropertyChanging();
					this._StartingNumMiles = value;
					this.SendPropertyChanged("StartingNumMiles");
					this.OnStartingNumMilesChanged();
				}
			}
		}
		
		[Column(Storage="_FinishingNumMiles", DbType="Float")]
		public System.Nullable<double> FinishingNumMiles
		{
			get
			{
				return this._FinishingNumMiles;
			}
			set
			{
				if ((this._FinishingNumMiles != value))
				{
					this.OnFinishingNumMilesChanging(value);
					this.SendPropertyChanging();
					this._FinishingNumMiles = value;
					this.SendPropertyChanged("FinishingNumMiles");
					this.OnFinishingNumMilesChanged();
				}
			}
		}
		
		[Column(Storage="_StartingTotalSeconds", DbType="Int NOT NULL")]
		public int StartingTotalSeconds
		{
			get
			{
				return this._StartingTotalSeconds;
			}
			set
			{
				if ((this._StartingTotalSeconds != value))
				{
					this.OnStartingTotalSecondsChanging(value);
					this.SendPropertyChanging();
					this._StartingTotalSeconds = value;
					this.SendPropertyChanged("StartingTotalSeconds");
					this.OnStartingTotalSecondsChanged();
				}
			}
		}
		
		[Column(Storage="_FinishingTotalSeconds", DbType="Int")]
		public System.Nullable<int> FinishingTotalSeconds
		{
			get
			{
				return this._FinishingTotalSeconds;
			}
			set
			{
				if ((this._FinishingTotalSeconds != value))
				{
					this.OnFinishingTotalSecondsChanging(value);
					this.SendPropertyChanging();
					this._FinishingTotalSeconds = value;
					this.SendPropertyChanged("FinishingTotalSeconds");
					this.OnFinishingTotalSecondsChanged();
				}
			}
		}
		
		[Association(Name="WorkoutRegimen_Workout", Storage="_Workouts", ThisKey="WorkoutRegimenId", OtherKey="WorkoutRegimenId")]
		public EntitySet<Workout> Workouts
		{
			get
			{
				return this._Workouts;
			}
			set
			{
				this._Workouts.Assign(value);
			}
		}
		
		[Association(Name="FitnessUser_WorkoutRegimen", Storage="_FitnessUser", ThisKey="FitnessUserId", OtherKey="FitnessUserId", IsForeignKey=true)]
		public FitnessUser FitnessUser
		{
			get
			{
				return this._FitnessUser.Entity;
			}
			set
			{
				FitnessUser previousValue = this._FitnessUser.Entity;
				if (((previousValue != value) 
							|| (this._FitnessUser.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._FitnessUser.Entity = null;
						previousValue.WorkoutRegimens.Remove(this);
					}
					this._FitnessUser.Entity = value;
					if ((value != null))
					{
						value.WorkoutRegimens.Add(this);
						this._FitnessUserId = value.FitnessUserId;
					}
					else
					{
						this._FitnessUserId = default(int);
					}
					this.SendPropertyChanged("FitnessUser");
				}
			}
		}
		
		[Association(Name="ExerciseType_WorkoutRegimen", Storage="_ExerciseType", ThisKey="ExerciseTypeId", OtherKey="ExerciseTypeId", IsForeignKey=true)]
		public ExerciseType ExerciseType
		{
			get
			{
				return this._ExerciseType.Entity;
			}
			set
			{
				ExerciseType previousValue = this._ExerciseType.Entity;
				if (((previousValue != value) 
							|| (this._ExerciseType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ExerciseType.Entity = null;
						previousValue.WorkoutRegimens.Remove(this);
					}
					this._ExerciseType.Entity = value;
					if ((value != null))
					{
						value.WorkoutRegimens.Add(this);
						this._ExerciseTypeId = value.ExerciseTypeId;
					}
					else
					{
						this._ExerciseTypeId = default(int);
					}
					this.SendPropertyChanged("ExerciseType");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Workouts(Workout entity)
		{
			this.SendPropertyChanging();
			entity.WorkoutRegimen = this;
		}
		
		private void detach_Workouts(Workout entity)
		{
			this.SendPropertyChanging();
			entity.WorkoutRegimen = null;
		}
	}
	
	[Table(Name="dbo.Workouts")]
	public partial class Workout : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _WorkoutId;
		
		private int _WorkoutRegimenId;
		
		private System.DateTime _StartingTime;
		
		private double _NumMiles;
		
		private int _TotalSeconds;
		
		private EntityRef<WorkoutRegimen> _WorkoutRegimen;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnWorkoutIdChanging(int value);
    partial void OnWorkoutIdChanged();
    partial void OnWorkoutRegimenIdChanging(int value);
    partial void OnWorkoutRegimenIdChanged();
    partial void OnStartingTimeChanging(System.DateTime value);
    partial void OnStartingTimeChanged();
    partial void OnNumMilesChanging(double value);
    partial void OnNumMilesChanged();
    partial void OnTotalSecondsChanging(int value);
    partial void OnTotalSecondsChanged();
    #endregion
		
		public Workout()
		{
			this._WorkoutRegimen = default(EntityRef<WorkoutRegimen>);
			OnCreated();
		}
		
		[Column(Storage="_WorkoutId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int WorkoutId
		{
			get
			{
				return this._WorkoutId;
			}
			set
			{
				if ((this._WorkoutId != value))
				{
					this.OnWorkoutIdChanging(value);
					this.SendPropertyChanging();
					this._WorkoutId = value;
					this.SendPropertyChanged("WorkoutId");
					this.OnWorkoutIdChanged();
				}
			}
		}
		
		[Column(Storage="_WorkoutRegimenId", DbType="Int NOT NULL")]
		public int WorkoutRegimenId
		{
			get
			{
				return this._WorkoutRegimenId;
			}
			set
			{
				if ((this._WorkoutRegimenId != value))
				{
					if (this._WorkoutRegimen.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnWorkoutRegimenIdChanging(value);
					this.SendPropertyChanging();
					this._WorkoutRegimenId = value;
					this.SendPropertyChanged("WorkoutRegimenId");
					this.OnWorkoutRegimenIdChanged();
				}
			}
		}
		
		[Column(Storage="_StartingTime", DbType="DateTime NOT NULL")]
		public System.DateTime StartingTime
		{
			get
			{
				return this._StartingTime;
			}
			set
			{
				if ((this._StartingTime != value))
				{
					this.OnStartingTimeChanging(value);
					this.SendPropertyChanging();
					this._StartingTime = value;
					this.SendPropertyChanged("StartingTime");
					this.OnStartingTimeChanged();
				}
			}
		}
		
		[Column(Storage="_NumMiles", DbType="Float NOT NULL")]
		public double NumMiles
		{
			get
			{
				return this._NumMiles;
			}
			set
			{
				if ((this._NumMiles != value))
				{
					this.OnNumMilesChanging(value);
					this.SendPropertyChanging();
					this._NumMiles = value;
					this.SendPropertyChanged("NumMiles");
					this.OnNumMilesChanged();
				}
			}
		}
		
		[Column(Storage="_TotalSeconds", DbType="Int NOT NULL")]
		public int TotalSeconds
		{
			get
			{
				return this._TotalSeconds;
			}
			set
			{
				if ((this._TotalSeconds != value))
				{
					this.OnTotalSecondsChanging(value);
					this.SendPropertyChanging();
					this._TotalSeconds = value;
					this.SendPropertyChanged("TotalSeconds");
					this.OnTotalSecondsChanged();
				}
			}
		}
		
		[Association(Name="WorkoutRegimen_Workout", Storage="_WorkoutRegimen", ThisKey="WorkoutRegimenId", OtherKey="WorkoutRegimenId", IsForeignKey=true)]
		public WorkoutRegimen WorkoutRegimen
		{
			get
			{
				return this._WorkoutRegimen.Entity;
			}
			set
			{
				WorkoutRegimen previousValue = this._WorkoutRegimen.Entity;
				if (((previousValue != value) 
							|| (this._WorkoutRegimen.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._WorkoutRegimen.Entity = null;
						previousValue.Workouts.Remove(this);
					}
					this._WorkoutRegimen.Entity = value;
					if ((value != null))
					{
						value.Workouts.Add(this);
						this._WorkoutRegimenId = value.WorkoutRegimenId;
					}
					else
					{
						this._WorkoutRegimenId = default(int);
					}
					this.SendPropertyChanged("WorkoutRegimen");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="dbo.ExerciseTypes")]
	public partial class ExerciseType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ExerciseTypeId;
		
		private string _Name;
		
		private System.Nullable<bool> _IsDistanceUsed;
		
		private System.Nullable<int> _MinSecondsPerMile;
		
		private System.Nullable<int> _MaxSecondsPerMile;
		
		private EntitySet<WorkoutRegimen> _WorkoutRegimens;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnExerciseTypeIdChanging(int value);
    partial void OnExerciseTypeIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnIsDistanceUsedChanging(System.Nullable<bool> value);
    partial void OnIsDistanceUsedChanged();
    partial void OnMinSecondsPerMileChanging(System.Nullable<int> value);
    partial void OnMinSecondsPerMileChanged();
    partial void OnMaxSecondsPerMileChanging(System.Nullable<int> value);
    partial void OnMaxSecondsPerMileChanged();
    #endregion
		
		public ExerciseType()
		{
			this._WorkoutRegimens = new EntitySet<WorkoutRegimen>(new Action<WorkoutRegimen>(this.attach_WorkoutRegimens), new Action<WorkoutRegimen>(this.detach_WorkoutRegimens));
			OnCreated();
		}
		
		[Column(Storage="_ExerciseTypeId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ExerciseTypeId
		{
			get
			{
				return this._ExerciseTypeId;
			}
			set
			{
				if ((this._ExerciseTypeId != value))
				{
					this.OnExerciseTypeIdChanging(value);
					this.SendPropertyChanging();
					this._ExerciseTypeId = value;
					this.SendPropertyChanged("ExerciseTypeId");
					this.OnExerciseTypeIdChanged();
				}
			}
		}
		
		[Column(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_IsDistanceUsed", DbType="Bit")]
		public System.Nullable<bool> IsDistanceUsed
		{
			get
			{
				return this._IsDistanceUsed;
			}
			set
			{
				if ((this._IsDistanceUsed != value))
				{
					this.OnIsDistanceUsedChanging(value);
					this.SendPropertyChanging();
					this._IsDistanceUsed = value;
					this.SendPropertyChanged("IsDistanceUsed");
					this.OnIsDistanceUsedChanged();
				}
			}
		}
		
		[Column(Storage="_MinSecondsPerMile", DbType="Int")]
		public System.Nullable<int> MinSecondsPerMile
		{
			get
			{
				return this._MinSecondsPerMile;
			}
			set
			{
				if ((this._MinSecondsPerMile != value))
				{
					this.OnMinSecondsPerMileChanging(value);
					this.SendPropertyChanging();
					this._MinSecondsPerMile = value;
					this.SendPropertyChanged("MinSecondsPerMile");
					this.OnMinSecondsPerMileChanged();
				}
			}
		}
		
		[Column(Storage="_MaxSecondsPerMile", DbType="Int")]
		public System.Nullable<int> MaxSecondsPerMile
		{
			get
			{
				return this._MaxSecondsPerMile;
			}
			set
			{
				if ((this._MaxSecondsPerMile != value))
				{
					this.OnMaxSecondsPerMileChanging(value);
					this.SendPropertyChanging();
					this._MaxSecondsPerMile = value;
					this.SendPropertyChanged("MaxSecondsPerMile");
					this.OnMaxSecondsPerMileChanged();
				}
			}
		}
		
		[Association(Name="ExerciseType_WorkoutRegimen", Storage="_WorkoutRegimens", ThisKey="ExerciseTypeId", OtherKey="ExerciseTypeId")]
		public EntitySet<WorkoutRegimen> WorkoutRegimens
		{
			get
			{
				return this._WorkoutRegimens;
			}
			set
			{
				this._WorkoutRegimens.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_WorkoutRegimens(WorkoutRegimen entity)
		{
			this.SendPropertyChanging();
			entity.ExerciseType = this;
		}
		
		private void detach_WorkoutRegimens(WorkoutRegimen entity)
		{
			this.SendPropertyChanging();
			entity.ExerciseType = null;
		}
	}
}
#pragma warning restore 1591
