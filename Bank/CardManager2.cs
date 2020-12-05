using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bank
{
    public class CardManager2
    {
        private readonly string _bankName;
        private readonly string _duration;
        private readonly string _cardType;
        private readonly Random _random;
        private readonly User _user;


        public CardManager2(string bankName, string duration, string cardType, User user)
        {
            _bankName = bankName;
            _duration = duration;
            _cardType = cardType;
            _random = new Random();
            _user = user;
        }
        private string GetCardNumber()
        {
            StringBuilder cardNumber = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                cardNumber.Append(_random.Next(100000, 999999));

            }
            return cardNumber.ToString();
        }
        private short GetCvc()
        {
            return (short)_random.Next(1000, 9999);

        }
        private DateTime GetExprideDate()
        {
            return DateTime.Now.AddYears(int.Parse(_duration));

        }
        private BankName GetBankName()
        {
            BankName bank = default;
            switch (_bankName)
            {
                case "BeynaxalgBank": bank = BankName.BeynaxalgBank;
                    break;
                case "AccessBank":
                    bank = BankName.AccessBank;
                    break;
                case "KapitalBank":
                    bank = BankName.KapitalBank;
                    break;
                case "AFBBank":
                    bank = BankName.AFBBank;
                    break;
                case "ASB":
                    bank = BankName.ASB;
                    break;
                case "AzərTürkBank":
                    bank = BankName.AzərTürkBank;
                    break;
                case "BankBTB":
                    bank = BankName.BankBTB;
                    break;
                case "BankEurasia":
                    bank = BankName.BankEurasia;
                    break;
                case "BankMelliIran":
                    bank = BankName.BankMelliIran;
                    break;
                case "BankofBaku":
                    bank = BankName.BankofBaku;
                    break;
                case "BankRespublika":
                    bank = BankName.BankRespublika;
                    break;
                case "PremiumBankBankSilkWay":
                    bank = BankName.PremiumBankBankSilkWay;
                    break;
                case "CaucasusDevelopmentBank":
                    bank = BankName.CaucasusDevelopmentBank;
                    break;
                case "Expressbank":
                    bank = BankName.Expressbank;
                    break;
                case "GünayBank":
                    bank = BankName.GünayBank;
                    break;
                case "InternationalBankofAzerbaijan":
                    bank = BankName.InternationalBankofAzerbaijan;
                    break;
                case "MuganBank":
                    bank = BankName.MuganBank;
                    break;
                case "Nakhchivanbank":
                    bank = BankName.Nakhchivanbank;
                    break;
                case "NationalBankofPakistan":
                    bank = BankName.NationalBankofPakistan;
                    break;
                case "NBCBank":
                    bank = BankName.NBCBank;
                    break;
                case "YeloBankNikoilBank)":
                    bank = BankName.YeloBankNikoilBank;
                    break;
                case "PAŞABank":
                    bank = BankName.PAŞABank;
                    break;
                case "Rabitabank":
                    bank = BankName.Rabitabank;
                    break;
                case "TuranBank":
                    bank = BankName.TuranBank;
                    break;
                case "Unibank":
                    bank = BankName.Unibank;
                    break;
                case "VTBBankAzerbaijan":
                    bank = BankName.VTBBankAzerbaijan;
                    break;
                case "XalqBank":
                    bank = BankName.XalqBank;
                    break;
                case "YapiKrediBankAzerbaijan":
                    bank = BankName.YapiKrediBankAzerbaijan;
                    break;
              
            }
            return bank;
        }
        private CardType GetCardType()
        {
            CardType card = default;
            switch (_cardType)
            {
                case "MasterCard":
                    card = CardType.MasterCard;
                    break;
                case "Visa":
                    card = CardType.Visa;
                    break;
            }
            return card;
        }
        private DurationType GetDurationType()
        {
            DurationType duration = default;
            switch (int.Parse(_duration))
            {
                case (int)DurationType.OneYears: duration = DurationType.OneYears; break;
                case  (int)DurationType.TwoYears: duration = DurationType.TwoYears; break;
                case  (int)DurationType.threeYears: duration = DurationType.threeYears; break;
                case  (int)DurationType.fourYears: duration = DurationType.fourYears; break;
                case (int)DurationType.fiveYears: duration = DurationType.fiveYears; break;
                case (int)DurationType.sixYears: duration = DurationType.sixYears; break;
                case  (int)DurationType.sevenYears:  duration = DurationType.sevenYears; break;
                case  (int)DurationType.eightYears: duration = DurationType.eightYears;  break;
                case  (int)DurationType.nineYears: duration = DurationType.nineYears; break;
                case  (int)DurationType.tenYears: duration = DurationType.tenYears; break;
            }
            return duration;
        }
        public Card GetCard()
        {
            return new Card
            {
                Id = Ibentificator<Card>.GetId(),
                Bank = GetBankName(),
                CVC = GetCvc(),
                Duration = GetDurationType(),
                ExpiredDate = GetExprideDate(),
                CardType = GetCardType(),
                CardNumber = GetCardNumber(),
                CardHolder = $"{_user.name} {_user.Surname}",
                CardHolderId = _user.Id
            };
        }
    }
}
