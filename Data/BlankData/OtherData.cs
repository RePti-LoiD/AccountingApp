namespace AccountingApp.Data.BlankData
{
    public class OtherData
    {
        private string pcID;

        private ComputerType computerType;

        private string userName;
        private string ipAdress;

        private int ramSize;
        private int ramCount;
        private string hdd;

        private string motherBoard;
        private string osName;
        private bool isActivated;
        private string activationKey;

        public string PcID { get => pcID; set => pcID = value; }
        public string UserName { get => userName; set => userName = value; }
        public string IpAdress { get => ipAdress; set => ipAdress = value; }
        public string MotherBoard { get => motherBoard; set => motherBoard = value; }
        public string OsName { get => osName; set => osName = value; }
        public bool IsActivated { get => isActivated; set => isActivated = value; }
        public string ActivationKey { get => activationKey; set => activationKey = value; }
        public ComputerType ComputerType { get => computerType; set => computerType = value; }

        public string ComputerNameOs { get => $"Компьютер / {userName}"; }
        public int RamSize { get => ramSize; set => ramSize = value; }
        public int RamCount { get => ramCount; set => ramCount = value; }
        public string Hdd { get => hdd; set => hdd = value; }
    }
}