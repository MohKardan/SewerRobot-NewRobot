using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewerRobot
{
    class Error
    {
        public Error()
        {
            _StructureErrors = new string[] { "ترک", "شکاف", "شکستگی", "سوراخ", "تغییر شکل", "فروریزش", "اتصال باز", "جابجایی در محل اتصال", "آسیب های سطحی" };
            _ServiceErrors = new string[] { "نفوذ ریشه", "نشتاب", "تراوش", "رسوبات چسبیده", "رسوبات ته نشین شده", "نفوذ خاک به داخل لوله", "مانع در مسیر", "تراز آب" };
            _RunErrors = new string[] { "محل اتصال فاضلابروي جانبی", "محل اتصال انشعاب", "اتصال جانبی معیوب", "آب بند معیوب", "پوشش داخلی معیوب", "تعمیر معیوب", "جوش معیوب در محل اتصال", "تعمیر موضعی", "خاك قابل مشاهده در آن سوي جداره لوله", "حفره قابل مشاهده در آن سوي جداره لوله" };

        }
        private bool _StartTimeTemp, _EndTimeTemp, _PercentTemp, _DiameterTemp;
        private string _TypeErrorTemp = null;   //this variable hold amount of errortype
        private string _ErrorTemp;
        private string _ErrorCodeTemp, _ErrorTypeTemp, _EndNameTemp;
        private string[] _StructureErrors;
        private string[] _ServiceErrors;
        private string[] _RunErrors;
        public string[] StructureErrors
        {
            get
            {
                return this._StructureErrors;
            }
            set
            {
                this._StructureErrors = value;
            }
        }
        public string[] ServiceErrors
        {
            get
            {
                return this._ServiceErrors;
            }
            set
            {
                this._ServiceErrors = value;
            }
        }
        public string[] RunErrors
        {
            get
            {
                return this._RunErrors;
            }
            set
            {
                this._ServiceErrors = value;
            }
        }
        public string ErrorTypeTemp
        {
            get
            {
                return this._ErrorTypeTemp;
            }
            set
            {
                this._ErrorTypeTemp = value;
            }
        }
        public string ErrorCodeTemp
        {
            get
            {
                return this._ErrorCodeTemp;
            }
            set
            {
                this._ErrorCodeTemp = value;
            }
        }
        public string TypeErrorTemp
        {
            get
            {
                return this._TypeErrorTemp;
            }
            set
            {
                this._TypeErrorTemp = value;
            }
        }
        public string EndNameTemp
        {
            get { return this._EndNameTemp; }
            set { this._EndNameTemp = value; }
        }
        public bool StartTimeTemp
        {
            get
            {
                return this._StartTimeTemp;
            }
            set
            {
                this._StartTimeTemp = value;
            }
        }
        public bool EndTimeTemp
        {
            get
            {
                return this._EndTimeTemp;
            }
            set
            {
                this._EndTimeTemp = value;
            }
        }
        public bool PercentTemp
        {
            get
            {
                return this._PercentTemp;
            }
            set
            {
                this._PercentTemp = value;
            }
        }
        public bool DiameterTemp
        {
            get
            {
                return this._DiameterTemp;
            }
            set
            {
                this._DiameterTemp = value;
            }
        }



        public string[] SetStructureErrorsType(string S)
        {
            string[] tmp = null;
            ErrorTypeTemp = null;
            switch (S)
            {
                case "ترک":
                case "شکاف":
                    ErrorTypeTemp = S;
                    tmp = new string[] { "طولی", "پیرامونی", "مرکب", "مارپیچ" };
                    break;
                case "شکستگی":
                    ErrorCodeTemp = "شکستگی در لوله";
                    break;
                case "سوراخ":
                    ErrorCodeTemp = "سوراخ در دیواره ي فاضلابرو";
                    break;
                case "تغییر شکل":
                    ErrorCodeTemp = "تغییر شکل در فاضلابرو";
                    break;
                case "فروریزش":
                    ErrorCodeTemp = "فروریزش در لوله";
                    break;
                case "جابجایی در محل اتصال":
                    ErrorTypeTemp = "جابجایی در محل اتصال به میزان";
                    tmp = new string[] { "متوسط", "زیاد", "%" };
                    break;
                case "اتصال باز":
                    tmp = new string[] { "متوسط", "زیاد", "%" };
                    break;
                case "آسیب های سطحی":
                    tmp = new string[] { "افزایش زبری", "پوسته شدن سطح", "نمایان شدن سنگدانه ها", "بیرون زدگی سنگدانه ها", "نمایان شدن آرماتورها", "بیرون زدگی آرماتورها", "خوردگی تسلیحات بتن", "محصول خوردگی", "سایر عیوب سطحی" };
                    break;
            }
            return tmp;
        }

        public string[] SetServiceErrorsType(string S)
        {
            string[] tmp = null;
            ErrorTypeTemp = null;
            switch (S)
            {
                case "نفوذ ریشه":
                    ErrorTypeTemp = "نفوذ";
                    tmp = new string[] { "ریشه های نازک", "تک ریشه ضخیم", "انبوه ریشه ها" };
                    break;
                case "نشتاب":
                    tmp = new string[] { "نشت", "چکیدن", "جریان دار", "فوران نشتاب" };
                    break;
                case "تراوش":
                    ErrorTypeTemp = "تراوش";
                    break;
                case "رسوبات چسبیده":
                    tmp = new string[] { "قشری", "فاضلابی", "گریسی", "سایر انواع رسوبات چسبیده" };
                    break;
                case "رسوبات ته نشین شده":
                    tmp = new string[] { "ریزدانه", "درشت دانه", "سخت و فشرده", "سایر انواع رسوبات ته نشین شده" };
                    break;
                case "نفوذ خاک به داخل لوله":
                    ErrorTypeTemp = "نفوذ";
                    tmp = new string[] { "نفوذ ماسه", "نفوذ خاک پیت", "نفوذ مواد ریزدانه", "نفوذ شن", "نفوذ سایر انواع خاک" };
                    break;
                case "مانع در مسیر":
                    tmp = new string[] { "آجر یا سایر مصالح بنایی در کف", "تکه های شکسته لوله در کف", "وجود سایر موانع در کف", "نفوذ موانع به داخل لوله از دیواره", "نفوذ موانع به داخل لوله اصلی از طریق انشعابات", "تعبیه ي کابل یا لوله ي خارجی داخل مجراي فاضلابرو", "سایر موانع" };
                    break;
                case "تراز آب":
                    tmp = new string[] { "تراز آب", "تراز آب زلال", "تراز آب کدر" };
                    break;
            }
            return tmp;
        }

        public string[] SetRunErrorsType(string S)
        {
            ErrorTypeTemp = null;
            string[] tmp = null;
            switch (S)
            {
                case "محل اتصال فاضلابروي جانبی":
                    ErrorTypeTemp = "محل اتصال فاضلابروي جانبی";
                    tmp = new string[] { "فاضلابروي جانبی", "فاضلابروي جانبی مسدود شده" };
                    break;
                case "محل اتصال انشعاب":
                    ErrorTypeTemp = "اتصال انشعاب";
                    tmp = new string[] { "انشعاب جانبی", "انشعاب جانبی مسدود شده" };
                    break;
                case "اتصال جانبی معیوب":
                    tmp = new string[] { "اتصال معیوب انشعاب", "انشعاب در موقعیت قرارگیري نامناسب", "لوله ي انشعاب معیوب", "انسداد در انشعاب", "سایر عیوب در انشعاب", "(انشعاب مهاجم(نفوذ به داخل لوله", "اتصال معیوب فاضلابروي جانبی", "فاضلابروي جانبی در موقعیت قرارگیري نامناسب", "فاضلابروي جانبی معیوب", "انسداد در فاضلابروي جانبی", "سایر عیوب در فاضلابروي جانبی" };
                    break;
                case "آب بند معیوب":
                    tmp = new string[] { "ورود واشر آب بند به فضاي داخل لوله", "پارگی در واشر آب بند", "نفوذ سایر انواع قطعات آب بند" };
                    break;
                case "پوشش داخلی معیوب":
                    ErrorTypeTemp = "پوشش داخلی معیوب";
                    tmp = new string[] { "جداشدگی پوشش", "تغییر رنگ پوشش", "عیب در بخش انتهایی پوشش", "جمع شدگی طولی پوشش", "جمع شدگی پیرامونی پوشش", "جمع شدگی مارپیچ پوشش", "بروز تاول در پوشش", "بروز سایر عیوب در پوشش" };
                    break;
                case "تعمیر معیوب":
                    ErrorTypeTemp = "تعمیر معیوب";
                    tmp = new string[] { "از بین رفتن دیواره", "سایر عیوب" };
                    break;
                case "جوش معیوب در محل اتصال":
                    ErrorTypeTemp = "جوش";
                    tmp = new string[] { "طولی", "پیرامونی", "مارپیچ" };
                    break;
                case "تعمیر موضعی":
                    ErrorTypeTemp = "تعمیر موضعی";
                    tmp = new string[] { "جایگزینی قسمتی از لوله", "نصب وصله ي موضعی", "تزریق ملات سیمانی", "تزریق سایر انواع ملات", "تعمیر حفره ي موجود در جداره ي لوله", "سایر تعمیرات بدون ترانشه" };
                    break;
                case "خاك قابل مشاهده در آن سوي جداره لوله":
                    ErrorTypeTemp = "خاك قابل مشاهده در آن سوي جداره لوله";
                    break;
                case "حفره قابل مشاهده در آن سوي جداره لوله":
                    ErrorTypeTemp = "حفره قابل مشاهده در آن سوي جداره لوله";
                    break;
            }
            return tmp;
        }

        public void SetStructureErrorsTypeName(string S)
        {
            StartTimeTemp = false;
            EndTimeTemp = false;
            PercentTemp = false;
            ErrorCodeTemp = null;
            _EndNameTemp = "";
            switch (S)
            {
                case "طولی":
                    ErrorCodeTemp = S;
                    StartTimeTemp = true;
                    break;
                case "پیرامونی":
                case "مرکب":
                case "مارپیچ":
                    ErrorCodeTemp = S;
                    StartTimeTemp = true;
                    EndTimeTemp = true;
                    break;
                case "متوسط":
                    if (TypeErrorTemp == "جابجایی در محل اتصال")
                        ErrorCodeTemp = S;
                    else
                        ErrorCodeTemp = "بازشدگی متوسط محل اتصال";
                    break;
                case "زیاد":
                    if (TypeErrorTemp == "جابجایی در محل اتصال")
                        ErrorCodeTemp = S;
                    else
                        ErrorCodeTemp = "بازشدگی زیاد محل اتصال";
                    break;
                case "%":
                    if (TypeErrorTemp == "اتصال باز")
                        ErrorCodeTemp = "جابجایی در محل اتصال به میزان";
                    EndNameTemp = "از قطر";
                    PercentTemp = true;
                    break;
                case "افزایش زبری":
                case "پوسته شدن سطح":
                case "نمایان شدن سنگدانه ها":
                case "بیرون زدگی سنگدانه ها":
                case "نمایان شدن آرماتورها":
                case "بیرون زدگی آرماتورها":
                case "خوردگی تسلیحات بتن":
                case "محصول خوردگی":
                case "سایر عیوب سطحی":
                    ErrorCodeTemp = S;
                    StartTimeTemp = true;
                    EndTimeTemp = true;
                    break;
            }
        }
        public void SetServiceErrorsTypeName(string S)
        {
            StartTimeTemp = false;
            EndTimeTemp = false;
            PercentTemp = false;
            ErrorCodeTemp = null;
            _EndNameTemp = "";
            switch (S)
            {
                case "ریشه های نازک":
                    ErrorCodeTemp = "ریشه های نازک";
                    break;
                case "تک ریشه ضخیم":
                    ErrorCodeTemp = "تک ریشه ضخیم";
                    break;
                case "انبوه ریشه ها":
                    ErrorCodeTemp = "انبوه ریشه ها و کاهش سطح مقطع به میزان";
                    PercentTemp = true;

                    break;
                case "نشت":
                    ErrorCodeTemp = "نشتاب از نوع نشت";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    break;
                case "چکیدن":
                    ErrorCodeTemp = "نشتاب از نوع چکیدن";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    break;
                case "جریان دار":
                    ErrorCodeTemp = "نشتاب از نوع جریان دار";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    break;
                case "فوران نشتاب":
                    ErrorCodeTemp = "فوران نشتاب";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    break;
                case "قشری":
                    ErrorCodeTemp = "رسوبات چسبیده از نوع قشري";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "فاضلابی":
                    ErrorCodeTemp = "رسوبات چسبیده از نوع فاضلابی";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "گریسی":
                    ErrorCodeTemp = "رسوبات چسبیده از نوع گریسی";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "سایر انواع رسوبات چسبیده":
                    ErrorCodeTemp = "سایر انواع رسوبات چسبیده";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "ریزدانه":
                    ErrorCodeTemp = "رسوبات ته نشین شده ي ریزدانه";
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "درشت دانه":
                    ErrorCodeTemp = "رسوبات ته نشین شده ي درشت دانه";
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "سخت و فشرده":
                    ErrorCodeTemp = "رسوبات ته نشین شده ي سخت و فشرده";
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "سایر انواع رسوبات ته نشین شده":
                    ErrorCodeTemp = "سایر انواع رسوبات ته نشین شده";
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "نفوذ ماسه":
                    ErrorCodeTemp = "ماسه به داخل لوله";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "نفوذ خاک پیت":
                    ErrorCodeTemp = "خاك پیت به داخل لوله ";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "نفوذ مواد ریزدانه":
                    ErrorCodeTemp = "مواد ریزدانه به داخل لوله";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "نفوذ شن":
                    ErrorCodeTemp = " شن به داخل لوله";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "نفوذ سایر انواع خاک":
                    ErrorCodeTemp = "سایر انواع خاك به داخل لوله";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "آجر یا سایر مصالح بنایی در کف":
                    ErrorCodeTemp = "وجود آجر یا سایر مصالح بنایی در کف فاضلابرو";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "تکه های شکسته لوله در کف":
                    ErrorCodeTemp = "وجود تکه هاي شکسته ي لوله در کف فاضلابرو";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "وجود سایر موانع در کف":
                    ErrorCodeTemp = " وجود سایر موانع در کف فاضلابرو";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "نفوذ موانع به داخل لوله از دیواره":
                    ErrorCodeTemp = "نفوذ موانع به داخل لوله از دیواره فاضلابرو";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "نفوذ موانع به داخل لوله اصلی از طریق انشعابات":
                    ErrorCodeTemp = "نفوذ موانع به داخل لوله اصلی از طریق انشعابات";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "تعبیه ي کابل یا لوله ي خارجی داخل مجراي فاضلابرو":
                    ErrorCodeTemp = "تعبیه ي کابل یا لوله ي خارجی داخل مجراي فاضلابرو";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "سایر موانع":
                    ErrorCodeTemp = "سایر موانع";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
            }
        }
        public void SetRunErrorsTypeName(string S)
        {
            StartTimeTemp = false;
            EndTimeTemp = false;
            DiameterTemp = false;
            PercentTemp = false;
            ErrorCodeTemp = null;
            switch (S)
            {
                case "فاضلابروي جانبی":
                    StartTimeTemp = true;
                    DiameterTemp = true;
                    break;
                case "فاضلابروي جانبی مسدود شده":
                    ErrorCodeTemp = "مسدود شده";
                    StartTimeTemp = true;
                    DiameterTemp = true;
                    break;
                case "انشعاب جانبی":
                    StartTimeTemp = true;
                    DiameterTemp = true;
                    break;
                case "انشعاب جانبی مسدود شده":
                    ErrorCodeTemp = "مسدود شده";
                    StartTimeTemp = true;
                    DiameterTemp = true;
                    break;
                case "اتصال معیوب انشعاب":
                case "انشعاب در موقعیت قرارگیري نامناسب":
                case "لوله ي انشعاب معیوب":
                case "انسداد در انشعاب":
                case "سایر عیوب در انشعاب":
                case "(انشعاب مهاجم(نفوذ به داخل لوله":
                case "اتصال معیوب فاضلابروي جانبی":
                case "فاضلابروي جانبی در موقعیت قرارگیري نامناسب":
                case "فاضلابروي جانبی معیوب":
                case "انسداد در فاضلابروي جانبی":
                case "سایر عیوب در فاضلابروي جانبی":
                    StartTimeTemp = true;
                    DiameterTemp = true;
                    PercentTemp = true;
                    ErrorCodeTemp = S;
                    break;
                case "ورود واشر آب بند به فضاي داخل لوله":
                case "پارگی در واشر آب بند":
                case "نفوذ سایر انواع قطعات آب بند":
                    ErrorCodeTemp = S;
                    StartTimeTemp = true;
                    EndTimeTemp = true;
                    break;
                case "جداشدگی پوشش":
                case "تغییر رنگ پوشش":
                case "عیب در بخش انتهایی پوشش":
                case "جمع شدگی طولی پوشش":
                case "جمع شدگی پیرامونی پوشش":
                case "جمع شدگی مارپیچ پوشش":
                case "بروز تاول در پوشش":
                case "بروز سایر عیوب در پوشش":
                    ErrorCodeTemp = S;
                    StartTimeTemp = true;
                    EndTimeTemp = true;
                    break;
                case "از بین رفتن دیواره":
                case "سایر عیوب":
                    ErrorCodeTemp = S;
                    StartTimeTemp = true;
                    EndTimeTemp = true;
                    break;
                case "طولی":
                case "پیرامونی":
                case "مارپیچ":
                    ErrorCodeTemp = S + " " + "معیوب در محل اتصال";
                    StartTimeTemp = true;
                    DiameterTemp = true;
                    break;
                case "جایگزینی قسمتی از لوله":
                case "نصب وصله ي موضعی":
                case "تزریق ملات سیمانی":
                case "تزریق سایر انواع ملات":
                case "تعمیر حفره ي موجود در جداره ي لوله":
                case "سایر تعمیرات بدون ترانشه":
                    ErrorCodeTemp = S;
                    StartTimeTemp = true;
                    EndTimeTemp = true;
                    break;
            }
        }

    }
}
