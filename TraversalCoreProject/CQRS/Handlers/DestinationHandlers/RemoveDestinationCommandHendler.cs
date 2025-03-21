﻿using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProject.CQRS.Commands.DestinationCommand;

namespace TraversalCoreProject.CQRS.Handlers.DestinationHandlers 
{
    public class RemoveDestinationCommandHendler
    {
        private readonly Context _context;
        public RemoveDestinationCommandHendler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveDestinationCommand command)
        {
            var values = _context.Destinations.Find(command.Id);
            _context.Destinations.Remove(values);
            _context.SaveChanges();
        }
    }
}
