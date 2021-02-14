using System.Collections.Generic;
using CommandApi.Models;
using System.Linq;
using System;

namespace  CommandApi.Data
{
    public class SqlCommandAPIRepo : ICommandAPIRepo
    {
        private readonly CommandContext _context;
        public SqlCommandAPIRepo(CommandContext context)
        {
            _context = context;
        }

        public void CreateCommand(Command cmd)
        {
            if(cmd == null)
            {
                throw new System.NotImplementedException();
            }
            _context.CommandItems.Add(cmd);
            SaveChanges();
        }

        public void DeleteCommand(Command cmd)
        {
            if(cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.CommandItems.Remove(cmd);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.CommandItems.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.CommandItems.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
           return (_context.SaveChanges() >= 0);
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }    
}