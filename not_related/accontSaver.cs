using System;

namespace AccountSaver
{
    public interface AccountSaver
    {
        bool Save(string account);
        string Get();
    }

    public class sqlAccount: AccountSaver
    {
        public bool Save(string account)
        {
            return true;
        }

        public string Get(){
            return "Yes";
        }
    }



}