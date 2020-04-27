using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Scripts
{
    class User
    {
        String login;
        String password;
        String name;

        // TODO: Объявить остальные поля добавить к ним геттеры и сеттеры.

        User(String login, String password)
        {
            this.login = login;
            this.password = password;
        }

    }
}
