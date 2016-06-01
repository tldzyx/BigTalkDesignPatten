using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume
{
    /// <summary>
    /// 简历
    /// </summary>
    public class Resume : ICloneable
    {
        private string _name;

        private string _sex;
        private string _age;

        //private string _timeArea;
        //private string _company;

        private readonly WorkExperience _work;

        public Resume(string name)
        {
            _name = name;
            _work = new WorkExperience();
        }

        private Resume(WorkExperience work)
        {
            _work = (WorkExperience)work.Clone();
        }

        /// <summary>
        /// 设置个人信息
        /// </summary>
        public void SetPersonalInfo(string sex, string age)
        {
            _sex = sex;
            _age = age;
        }

        ///// <summary>
        ///// 设置工作经历
        ///// </summary>
        //public void SetWorkExperience(string timeArea, string company)
        //{
        //    _timeArea = timeArea;
        //    _company = company;
        //}

        /// <summary>
        /// 设置工作经历
        /// </summary>
        public void SetWorkExperience(string workData, string company)
        {
            _work.WorkData = workData;
            _work.Company = company;
        }

        public void Display()
        {
            Console.WriteLine("{0} {1} {2}", _name, _sex, _age);
            //Console.WriteLine("工作经历：{0} {1}", _timeArea, _company);
            Console.WriteLine("工作经历：{0} {1}", _work.WorkData, _work.Company);
        }

        public object Clone()
        {
            Resume obj = new Resume(_work)
            {
                _name = _name,
                _sex = _sex,
                _age = _age
            };
            return obj;
        }
    }
}
