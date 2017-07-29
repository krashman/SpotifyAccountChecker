using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace SpotifyAccountChecker
{
    class AccountManager
    {
        public static List<Account> Accounts { get; private set; } = new List<Account>();

        public static bool LoadAccounts(string Path)
        {
            if (Accounts.Count > 0) Accounts.Clear();

            foreach(string Line in File.ReadLines(Path))
            {
                try
                {
                    string[] GetAccountInfo = Line.Split(':');
                    Accounts.Add(new Account { Username = GetAccountInfo[0], Password = GetAccountInfo[1] });
                }
                catch { continue; }
            }

            return (Accounts.Count > 0);
        }
    }
}
