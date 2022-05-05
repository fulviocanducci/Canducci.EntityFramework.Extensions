using System;

namespace DataAccess
{
    public static class LoadDatabase
    {
        public static void LoadPeople(this DatabaseContext data, int count = 100)
        {
            if (count <= 1)
            {
                throw new Exception("Count minimum error");
            }
            else
            {
                int i = 0;
                bool active = true;
                DateTime? updateAt = null;
                while (i < count)
                {
                    data.People.Add(new People
                    {
                        Id = Guid.NewGuid(),
                        Name = Guid.NewGuid().ToString(),
                        CreatedAt = DateTime.Now,
                        UpdateAt = updateAt,
                        Active = active
                    });
                    active = !active;
                    updateAt = updateAt == null ? (DateTime?)DateTime.Now : null;
                    i++;
                }
                data.SaveChanges();
            }
        }
    }
}
