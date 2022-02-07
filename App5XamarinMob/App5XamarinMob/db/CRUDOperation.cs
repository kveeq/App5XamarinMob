using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App5XamarinMob.db
{
    public class CRUDOperation
    {
        SQLiteConnection db;
        public CRUDOperation(string databasePath)
        {
            db = new SQLiteConnection(databasePath);
            db.CreateTable<ProjectModel>();
        }
        public IEnumerable<ProjectModel> GetProjects()
        {
            return db.Table<ProjectModel>();
        }

        public ProjectModel GetProjectItem(int id)
        {
            return db.Get<ProjectModel>(id);
        }

        public int DelProj(int id) { return db.Delete<ProjectModel>(id); }

        public int SaveItem(ProjectModel projectModel)
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