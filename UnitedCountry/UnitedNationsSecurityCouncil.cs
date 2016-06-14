using System;

namespace UnitedCountry
{
    internal class UnitedNationsSecurityCouncil : UnitedNations
    {
        private USA _colleague1;
        private Iraq _colleague2;

        public void SetUSA(USA colleague)
        {
            _colleague1 = colleague;
        }

        public void SetIraq(Iraq colleague)
        {
            _colleague2 = colleague;
        }
        
        public override void Declare(string message, Country colleague)
        {
            if (colleague == _colleague1)
            {
                _colleague2.GetMessage(message);
            }
            else
            {
                _colleague1.GetMessage(message);
            }
        }
    }
}