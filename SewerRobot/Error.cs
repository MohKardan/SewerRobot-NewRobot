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
                    ErrorTypeTemp = S;
                    tmp = new string[] { "طولی (CL)", "پیرامونی (CC)", "مرکب (CM)", "مارپیچ (CS)" };
                    break;
                case "شکاف":
                    ErrorTypeTemp = S;
                    tmp = new string[] { "طولی (FL)", "پیرامونی (FC)", "مرکب (FM)", "مارپیچ (FS)" };
                    break;
                case "شکستگی":
                    ErrorCodeTemp = "شکستگی در لوله (B)";
                    break;
                case "سوراخ":
                    ErrorCodeTemp = "سوراخ در دیواره ي فاضلابرو (H)";
                    break;
                case "تغییر شکل":
                    ErrorCodeTemp = "تغییر شکل در فاضلابرو (D)";
                    break;
                case "فروریزش":
                    ErrorCodeTemp = "فروریزش در لوله (XP)";
                    break;
                case "جابجایی در محل اتصال":
                    ErrorTypeTemp = "جابجایی در محل اتصال به میزان";
                    tmp = new string[] { "متوسط (JDM)", "زیاد (JDL)", "% (JD)" };
                    break;
                case "اتصال باز":
                    tmp = new string[] { "متوسط (OJM)", "زیاد (OJL)", "% (OJ)" };
                    break;
                case "آسیب های سطحی":
                    tmp = new string[] { "افزایش زبری (SW)", "پوسته شدن سطح (SS)", "نمایان شدن سنگدانه ها (SAV)", "بیرون زدگی سنگدانه ها (SAP)", "نمایان شدن آرماتورها (SRV)", "بیرون زدگی آرماتورها (SRP)", "خوردگی تسلیحات بتن (SRC)", "محصول خوردگی (SCP)", "سایر عیوب سطحی (SZ)" };
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
                    tmp = new string[] { "ریشه های نازک (RF)", "تک ریشه ضخیم (RT)", "انبوه ریشه ها (RM)" };
                    break;
                case "نشتاب":
                    tmp = new string[] { "نشت (IS)", "چکیدن (ID)", "جریان دار (IR)", "فوران نشتاب (IG)" };
                    break;
                case "تراوش":
                    ErrorTypeTemp = "تراوش (EX)";
                    break;
                case "رسوبات چسبیده":
                    tmp = new string[] { "قشری (DEE)", "فاضلابی (DEF)", "گریسی (DEG)", "سایر انواع رسوبات چسبیده (DEZ)" };
                    break;
                case "رسوبات ته نشین شده":
                    tmp = new string[] { "ریزدانه (DES)", "درشت دانه (DER)", "سخت و فشرده (DEC)", "سایر انواع رسوبات ته نشین شده (DEX)" };
                    break;
                case "نفوذ خاک به داخل لوله":
                    ErrorTypeTemp = "نفوذ";
                    tmp = new string[] { "نفوذ ماسه (INGS)", "نفوذ خاک پیت (INGP)", "نفوذ مواد ریزدانه (INGF)", "نفوذ شن (INGG)", "نفوذ سایر انواع خاک (INGZ)" };
                    break;
                case "مانع در مسیر":
                    tmp = new string[] { "آجر یا سایر مصالح بنایی در کف (OBB)", "تکه های شکسته لوله در کف (OBM)", "وجود سایر موانع در کف (OBX)", "نفوذ موانع به داخل لوله از دیواره (OBI)", "نفوذ موانع به داخل لوله اصلی از طریق انشعابات (OBC)", "تعبیه ي کابل یا لوله ي خارجی داخل مجراي فاضلابرو (OBP)", "سایر موانع (OBZ)" };
                    break;
                case "تراز آب":
                    tmp = new string[] { "تراز آب (WL)", "تراز آب زلال (WLC)", "تراز آب کدر (WLT)" };
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
                    tmp = new string[] { "فاضلابروي جانبی (JN)", "فاضلابروي جانبی مسدود شده (JNC)" };
                    break;
                case "محل اتصال انشعاب":
                    ErrorTypeTemp = "اتصال انشعاب";
                    tmp = new string[] { "انشعاب جانبی (CN)", "انشعاب جانبی مسدود شده (CNC)" };
                    break;
                case "اتصال جانبی معیوب":
                    tmp = new string[] { "اتصال معیوب انشعاب (CX)", "انشعاب در موقعیت قرارگیري نامناسب (CXP)", "لوله ي انشعاب معیوب (CXD)", "انسداد در انشعاب (CXB)", "سایر عیوب در انشعاب (CXZ)", "(انشعاب مهاجم(نفوذ به داخل لوله (CXI)", "اتصال معیوب فاضلابروي جانبی (JX)", "فاضلابروي جانبی در موقعیت قرارگیري نامناسب (JXP)", "فاضلابروي جانبی معیوب (JXD)", "انسداد در فاضلابروي جانبی (JXB)", "سایر عیوب در فاضلابروي جانبی (JXZ)" };
                    break;
                case "آب بند معیوب":
                    tmp = new string[] { "ورود واشر آب بند به فضاي داخل لوله (SR)", "پارگی در واشر آب بند (SRB)", "نفوذ سایر انواع قطعات آب بند (SO)" };
                    break;
                case "پوشش داخلی معیوب":
                    ErrorTypeTemp = "پوشش داخلی معیوب";
                    tmp = new string[] { "جداشدگی پوشش (LXD)", "تغییر رنگ پوشش (LXC)", "عیب در بخش انتهایی پوشش (LXE)", "جمع شدگی طولی پوشش (LXWL)", "جمع شدگی پیرامونی پوشش (LXWC)", "جمع شدگی مارپیچ پوشش (LXWM)", "بروز تاول در پوشش (LXB)", "بروز سایر عیوب در پوشش (LXZ)" };
                    break;
                case "تعمیر معیوب":
                    ErrorTypeTemp = "تعمیر معیوب";
                    tmp = new string[] { "از بین رفتن دیواره (RXM)", "سایر عیوب (RXZ)" };
                    break;
                case "جوش معیوب در محل اتصال":
                    ErrorTypeTemp = "جوش";
                    tmp = new string[] { "طولی (WXL)", "پیرامونی (WXC)", "مارپیچ (WXS)" };
                    break;
                case "تعمیر موضعی":
                    ErrorTypeTemp = "تعمیر موضعی";
                    tmp = new string[] { "جایگزینی قسمتی از لوله (RPR)", "نصب وصله ي موضعی (RPL)", "تزریق ملات سیمانی (RPI)", "تزریق سایر انواع ملات (RPS)", "تعمیر حفره ي موجود در جداره ي لوله (RPH)", "سایر تعمیرات بدون ترانشه (RPZ)" };
                    break;
                case "خاك قابل مشاهده در آن سوي جداره لوله":
                    ErrorTypeTemp = "خاك قابل مشاهده در آن سوي جداره لوله (SV)";
                    break;
                case "حفره قابل مشاهده در آن سوي جداره لوله":
                    ErrorTypeTemp = "حفره قابل مشاهده در آن سوي جداره لوله (VV)";
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
                case "طولی (CL)":
                case "طولی (FL)":
                    ErrorCodeTemp = S;
                    StartTimeTemp = true;
                    break;
                case "پیرامونی (CC)":
                case "مرکب (CM)":
                case "مارپیچ (CS)":
                case "پیرامونی (FC)":
                case "مرکب (FM)":
                case "مارپیچ (FS)":
                    ErrorCodeTemp = S;
                    StartTimeTemp = true;
                    EndTimeTemp = true;
                    break;
                case "متوسط (OJM)":
                    if (TypeErrorTemp == "جابجایی در محل اتصال")
                        ErrorCodeTemp = S;
                    else
                        ErrorCodeTemp = "بازشدگی متوسط محل اتصال (OJM)";
                    break;
                case "زیاد (OJL)":
                    if (TypeErrorTemp == "جابجایی در محل اتصال")
                        ErrorCodeTemp = S;
                    else
                        ErrorCodeTemp = "بازشدگی زیاد محل اتصال (OJL)";
                    break;
                case "% (OJ)":
                    if (TypeErrorTemp == "اتصال باز")
                        ErrorCodeTemp = "جابجایی در محل اتصال (OJ) به میزان ";
                    EndNameTemp = "از قطر";
                    PercentTemp = true;
                    break;
                case "افزایش زبری (SW)":
                case "پوسته شدن سطح (SS)":
                case "نمایان شدن سنگدانه ها (SAV)":
                case "بیرون زدگی سنگدانه ها (SAP)":
                case "نمایان شدن آرماتورها (SRV)":
                case "بیرون زدگی آرماتورها (SRP)":
                case "خوردگی تسلیحات بتن (SRC)":
                case "محصول خوردگی (SCP)":
                case "سایر عیوب سطحی (SZ)":
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
                case "ریشه های نازک (RF)":
                    ErrorCodeTemp = S;
                    break;
                case "تک ریشه ضخیم (RT)":
                    ErrorCodeTemp = S;
                    break;
                case "انبوه ریشه ها (RM)":
                    ErrorCodeTemp = "انبوه ریشه ها (RM) و کاهش سطح مقطع به میزان";
                    PercentTemp = true;

                    break;
                case "نشت (IS)":
                    ErrorCodeTemp = "نشتاب نشت (IS)";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    break;
                case "چکیدن (ID)":
                    ErrorCodeTemp = "نشتاب چکیدن (ID)";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    break;
                case "جریان دار (IR)":
                    ErrorCodeTemp = "نشتاب جریان دار (IR)";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    break;
                case "فوران نشتاب (IG)":
                    ErrorCodeTemp = S;
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    break;
                case "قشری (DEE)":
                    ErrorCodeTemp = "رسوبات چسبیده از نوع قشری (DEE)";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "فاضلابی (DEF)":
                    ErrorCodeTemp = "رسوبات چسبیده از نوع فاضلابی (DEF)";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "گریسی (DEG)":
                    ErrorCodeTemp = "رسوبات چسبیده از نوع گریسی (DEG)";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "سایر انواع رسوبات چسبیده (DEZ)":
                    ErrorCodeTemp = S;
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "ریزدانه (DES)":
                    ErrorCodeTemp = "رسوبات ته نشین شده ي ریزدانه (DES)";
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "درشت دانه (DER)":
                    ErrorCodeTemp = "رسوبات ته نشین شده ي درشت دانه (DER)";
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "سخت و فشرده (DEC)":
                    ErrorCodeTemp = "رسوبات ته نشین شده ي سخت و فشرده (DEC)";
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "سایر انواع رسوبات ته نشین شده (DEX)":
                    ErrorCodeTemp = S;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "نفوذ ماسه (INGS)":
                    ErrorCodeTemp = "ماسه به داخل لوله (INGS)";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "نفوذ خاک پیت (INGP)":
                    ErrorCodeTemp = "خاك پیت به داخل لوله (INGP)";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "نفوذ مواد ریزدانه (INGF)":
                    ErrorCodeTemp = "مواد ریزدانه به داخل لوله (INGF)";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "نفوذ شن (INGG)":
                    ErrorCodeTemp = " شن به داخل لوله (INGG)";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "نفوذ سایر انواع خاک (INGZ)":
                    ErrorCodeTemp = "سایر انواع خاك به داخل لوله (INGZ)";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "آجر یا سایر مصالح بنایی در کف (OBB)":
                    ErrorCodeTemp = "وجود آجر یا سایر مصالح بنایی در کف فاضلابرو (OBB)";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "تکه های شکسته لوله در کف (OBM)":
                    ErrorCodeTemp = "وجود تکه هاي شکسته ي لوله در کف فاضلابرو (OBM)";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "وجود سایر موانع در کف (OBX)":
                    ErrorCodeTemp = " وجود سایر موانع در کف فاضلابرو (OBX)";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "نفوذ موانع به داخل لوله از دیواره (OBI)":
                    ErrorCodeTemp = "نفوذ موانع به داخل لوله از دیواره فاضلابرو (OBI)";
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "نفوذ موانع به داخل لوله اصلی از طریق انشعابات (OBC)":
                    ErrorCodeTemp = S;
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "تعبیه ي کابل یا لوله ي خارجی داخل مجراي فاضلابرو (OBP)":
                    ErrorCodeTemp = S;
                    EndTimeTemp = true;
                    StartTimeTemp = true;
                    PercentTemp = true;
                    EndNameTemp = "کاهش سطح مقطع";
                    break;
                case "سایر موانع (OBZ)":
                    ErrorCodeTemp = S;
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
                case "فاضلابروي جانبی (JN)":
                    StartTimeTemp = true;
                    DiameterTemp = true;
                    break;
                case "فاضلابروي جانبی مسدود شده (JNC)":
                    ErrorCodeTemp = "مسدود شده (JNC)";
                    StartTimeTemp = true;
                    DiameterTemp = true;
                    break;
                case "انشعاب جانبی (CN)":
                    StartTimeTemp = true;
                    DiameterTemp = true;
                    break;
                case "انشعاب جانبی مسدود شده (CNC)":
                    ErrorCodeTemp = "مسدود شده (CNC)";
                    StartTimeTemp = true;
                    DiameterTemp = true;
                    break;
                case "اتصال معیوب انشعاب (CX)":
                case "انشعاب در موقعیت قرارگیري نامناسب (CXP)":
                case "لوله ي انشعاب معیوب (CXD)":
                case "انسداد در انشعاب (CXB)":
                case "سایر عیوب در انشعاب (CXZ)":
                case "(انشعاب مهاجم(نفوذ به داخل لوله (CXI)":
                case "اتصال معیوب فاضلابروي جانبی (JX)":
                case "فاضلابروي جانبی در موقعیت قرارگیري نامناسب (JXP)":
                case "فاضلابروي جانبی معیوب (JXD)":
                case "انسداد در فاضلابروي جانبی (JXB)":
                case "سایر عیوب در فاضلابروي جانبی (JXZ)":
                    StartTimeTemp = true;
                    DiameterTemp = true;
                    PercentTemp = true;
                    ErrorCodeTemp = S;
                    break;
                case "ورود واشر آب بند به فضاي داخل لوله (SR)":
                case "پارگی در واشر آب بند (SRB)":
                case "نفوذ سایر انواع قطعات آب بند (SO)":
                    ErrorCodeTemp = S;
                    StartTimeTemp = true;
                    EndTimeTemp = true;
                    break;
                case "جداشدگی پوشش (LXD)":
                case "تغییر رنگ پوشش (LXC)":
                case "عیب در بخش انتهایی پوشش (LXE)":
                case "جمع شدگی طولی پوشش (LXWL)":
                case "جمع شدگی پیرامونی پوشش (LXWC)":
                case "جمع شدگی مارپیچ پوشش (LXWM)":
                case "بروز تاول در پوشش (LXB)":
                case "بروز سایر عیوب در پوشش (LXZ)":
                    ErrorCodeTemp = S;
                    StartTimeTemp = true;
                    EndTimeTemp = true;
                    break;
                case "از بین رفتن دیواره (RXM)":
                case "سایر عیوب (RXZ)":
                    ErrorCodeTemp = S;
                    StartTimeTemp = true;
                    EndTimeTemp = true;
                    break;
                case "طولی (WXL)":
                case "پیرامونی (WXC)":
                case "مارپیچ (WXS)":
                    ErrorCodeTemp = S + " " + "معیوب در محل اتصال";
                    StartTimeTemp = true;
                    DiameterTemp = true;
                    break;
                case "جایگزینی قسمتی از لوله (RPR)":
                case "نصب وصله ي موضعی (RPL)":
                case "تزریق ملات سیمانی (RPI)":
                case "تزریق سایر انواع ملات (RPS)":
                case "تعمیر حفره ي موجود در جداره ي لوله (RPH)":
                case "سایر تعمیرات بدون ترانشه (RPZ)":
                    ErrorCodeTemp = S;
                    StartTimeTemp = true;
                    EndTimeTemp = true;
                    break;
            }
        }

    }
}
