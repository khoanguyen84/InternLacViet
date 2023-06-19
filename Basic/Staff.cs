namespace Basic
{
    class Staff 
    {
        public string StaffCode { get; set; }
        public string StaffName { get; set; }
        public Staff(string StaffCode, string StaffName)
        {
            this.StaffCode = StaffCode;
            this.StaffName = StaffName;
        }

        public string GetInfo()
        {
            return this.StaffName;
        }
        public string GetInfo(bool fullInfo)
        {
            if (fullInfo)
            {
                return $"{this.StaffCode}, {this.StaffName}";
            }
            return this.StaffCode;
        }

        public void GetInfo(bool fullInfo, bool isReturn)
        {
            if (fullInfo)
            {
                Console.WriteLine($"{this.StaffCode}, {this.StaffName}");
            }
            else
            {
                Console.WriteLine(this.StaffCode);
            }
        }
    }
}