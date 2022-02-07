using SQLite;
using System;
using System.Collections.Generic;
using App5XamarinMob.Models;
using System.Text;

namespace App5XamarinMob.db
{
    public class CRUDOperation
    {
        SQLiteConnection db;
        public CRUDOperation(string databasePath)
        {
            db = new SQLiteConnection(databasePath);
            db.CreateTable<Project>();
        }
        public IEnumerable<Project> GetProjects()
        {
            return db.Table<Project>();
        }

        public Project GetProjectItem(int id)
        {
            return db.Get<Project>(id);
        }

        public int DelProj(int id) { return db.Delete<Project>(id); }

        public int SaveItem(Project projectModel)
        {
            if (projectModel.Id != 0)
            {
                db.Update(projectModel);
                return projectModel.Id;
            }
            else
            {
                return db.Insert(projectModel);
            }
        }

    }
}