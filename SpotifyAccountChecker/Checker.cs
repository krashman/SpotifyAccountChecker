using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyAccountChecker
{
    class Checker
    {
        public List<Account> Accounts { get; private set; } = AccountManager.Accounts;

        public int MaxThreads { get; private set; } = 1;

        public MainForm Form { get; private set; }

        public Checker(int MaxThreads, MainForm Form)
        {
            this.MaxThreads = MaxThreads;
            this.Form = Form;
        }

        public void Start()
        {
            Parallel.ForEach(
                Accounts,
                new ParallelOptions() { MaxDegreeOfParallelism = MaxThreads },
                _Account =>
                {
                    try
                    {
                        if (new HttpManager(_Account).CheckAccount())
                        {
                            Form.UpdateAccountGrid(_Account);
                        }
                    }
                    catch { }
                });
        }
    }
}
