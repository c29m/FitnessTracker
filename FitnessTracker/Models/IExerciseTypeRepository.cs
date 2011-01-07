﻿using System;
using System.Linq;

namespace FitnessTracker.Models
{
    public interface IExerciseTypeRepository
    {
        IQueryable<ExerciseType> FindAllExerciseTypes();
        IQueryable<ExerciseType> FindByName(string name);

        ExerciseType GetExerciseType(int id);

        void Add(ExerciseType exerciseType);
        void Delete(ExerciseType exerciseType);
        void Save();
    }
}
