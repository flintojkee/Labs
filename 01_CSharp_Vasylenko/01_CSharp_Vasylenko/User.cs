using System;

namespace _01_CSharp_Vasylenko
{
     class User
        {
            private DateTime _dateOfBirth;
            private int _age;
            private string _chineseSign;
            private string _westernSign;

            public User(DateTime dateOfBirth)
            {
                DateOfBirth = dateOfBirth;
            }

            public DateTime DateOfBirth
        {
                set
                {
                    long d = DateTime.Today.Year - value.Year;
                    if (d <= 135 && d >= 0)
                    {
                        _dateOfBirth = value;
                        Age = CalculateAge();
                        CalculateZodiacs();
                    }
                    else
                        throw new Exception("Illegal date of birth!");
                }
            }

            public int Age
            {
                get
                {
                    return _age;
                }
                private set { _age = value; }
            }

            public string ChineseSign
            {
                get
                {
                    return _chineseSign;

                }
                private set
                {
                    _chineseSign = value;
                }
            }

            public string WesternSign
            {
                get { return _westernSign; }
                private set { _westernSign = value; }
            }

            private int CalculateAge()
            {
                DateTime today = DateTime.Today;
                if (today.DayOfYear <= _dateOfBirth.DayOfYear)
                    return today.Year - _dateOfBirth.Year - 1;
                return today.Year - _dateOfBirth.Year;
            }

            private void CalculateZodiacs()
            {
                switch (_dateOfBirth.Month)
                {
                    case 1:
                        if (_dateOfBirth.Day < 20)
                            WesternSign = "Capricorn";
                        else
                            WesternSign = "Aquarius";
                        break;
                    case 2:
                        if (_dateOfBirth.Day < 18)
                            WesternSign = "Aquarius";
                        else
                            WesternSign = "Pisces";
                        break;
                    case 3:
                        if (_dateOfBirth.Day < 20)
                            WesternSign = "Pisces";
                        else
                            WesternSign = "Aries";
                        break;
                    case 4:
                        if (_dateOfBirth.Day < 20)
                            WesternSign = "Aries";
                        else
                            WesternSign = "Taurus";
                        break;
                    case 5:
                        if (_dateOfBirth.Day < 21)
                            WesternSign = "Taurus";
                        else
                            WesternSign = "Gemini";
                        break;
                    case 6:
                        if (_dateOfBirth.Day < 21)
                            WesternSign = "Gemini";
                        else
                            WesternSign = "Cancer";
                        break;
                    case 7:
                        if (_dateOfBirth.Day < 23)
                            WesternSign = "Cancer";
                        else
                            WesternSign = "Leo";
                        break;
                    case 8:
                        if (_dateOfBirth.Day < 23)
                            WesternSign = "Leo";
                        else
                            WesternSign = "Virgo";
                        break;
                    case 9:
                        if (_dateOfBirth.Day < 23)
                            WesternSign = "Virgo";
                        else
                            WesternSign = "Libra";
                        break;
                    case 10:
                        if (_dateOfBirth.Day < 23)
                            WesternSign = "Libra";
                        else
                            WesternSign = "Scorpio";
                        break;
                    case 11:
                        if (_dateOfBirth.Day < 22)
                            WesternSign = "Scorpio";
                        else
                            WesternSign = "Sagittarius";
                        break;
                    case 12:
                        if (_dateOfBirth.Day < 22)
                            WesternSign = "Sagittarius";
                        else
                            WesternSign = "Capricorn";
                        break;
                }

                switch (_dateOfBirth.Year % 12)
                {
                    case 0:
                        ChineseSign = "Monkey";
                        break;
                    case 1:
                        ChineseSign = "Rooster";
                        break;
                    case 2:
                        ChineseSign = "Dog";
                        break;
                    case 3:
                        ChineseSign = "Pig";
                        break;
                    case 4:
                        ChineseSign = "Rat";
                        break;
                    case 5:
                        ChineseSign = "Ox";
                        break;
                    case 6:
                        ChineseSign = "Tiger";
                        break;
                    case 7:
                        ChineseSign = "Rabbit";
                        break;
                    case 8:
                        ChineseSign = "Dragon";
                        break;
                    case 9:
                        ChineseSign = "Snake";
                        break;
                    case 10:
                        ChineseSign = "Horse";
                        break;
                    case 11:
                        ChineseSign = "Sheep";
                        break;
                }
            }
        }
    }

