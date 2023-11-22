using Domain.Persistence;
using Model;

namespace Persistence;

public class Repository<T> : IRepository<T> where T : Contact
{
    private List<T> storage;
    public Repository()
    {
        storage = new List<T>();
    }

    public void Append(T model)
    {
        this.storage.Add(model);
    }

    public T[] GetAll()
    {
        return this.storage.ToArray();
    }

    public T Get(int id)
    {
        return this.storage.Where(x => x.Id == id).FirstOrDefault() ?? null;
    }

    public void Remove(int id)
    {
        int position = -1;

        for (int i = 0; i < this.storage.Count; i++)
        {
            if (this.storage[i].Id == id)
            {
                position = i;
                break;
            }
        }
        // this.storage.Remove(this.storage[position]);
        this.storage.RemoveAt(position);
    }

    public void Update(int id, T model)
    {
        var item = this.storage.FirstOrDefault(x => x.Id == id);
        if (item != null)
        {
            item = model;
        }
    }

    public override string ToString()
    {
        string output = String.Empty;

        var contacts = this.GetAll();

        for (int i = 0; i < contacts.Length; i++)
        {
            output += $"{contacts[i]}\n";
        }

        return output;
    }
}