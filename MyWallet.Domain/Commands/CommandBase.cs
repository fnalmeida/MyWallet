using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWallet.Domain.Commands
{
    public abstract class CommandBase : Notifiable<Notification>
    {

        public virtual bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}
