namespace _0_FrameWork.Application
{
    public class OperatResult
    {
        public bool IsSuccedded { get; set; }
        public string Massage { get; set; }

        public OperatResult()
        {
            IsSuccedded = false;
        }
        public OperatResult Succedded(string message="عملیات با موفقیات انجام شد")
        {
            IsSuccedded = true;
            Massage = message;
            return this;
        }
        public OperatResult Failed(string message)
        {
            IsSuccedded = false;
            Massage = message;
            return this;
        }
    }
}
