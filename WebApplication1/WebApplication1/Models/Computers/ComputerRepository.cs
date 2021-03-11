using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Models.Computers
{
    public class ComputerRepository
    {
        private MyContext _context = new MyContext();

        public List<Computer> SelectAll()
        {
            return this._context.Computer.ToList();
        }

        public void InsertInto(Computer computer)
        {
            this._context.Computer.Add(computer);
            this._context.SaveChanges();
        }

        public void Update(Computer computer)
        //Id = 3; Ip = 152.11.1.1; MacAddress = 15; ComputerName = PC
        {
            this._context.Entry(computer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this._context.SaveChanges();
        }

        public void Delete(Computer computer)
        {
            this._context.Computer.Remove(computer);
            this._context.SaveChanges();
        }

        public Computer SelectById(int id)
        {
            return this._context.Computer.Find(id);
        }
    }
}
