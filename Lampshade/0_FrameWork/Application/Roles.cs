namespace _0_FrameWork.Application
{
    public static class Roles
    {
        public const string Administration = "1";
        public const string SystemUser = "2";
        public const string ContentUploader = "3";
        public const string ColleagueUser = "5";

        public static string GetRoleBy(long id)
        {
            switch (id)
            {
                case 1:
                    return "مدیر سیستم";
                case 3:
                    return "محتوا گذار";
                default: 
                    return "";
            }
        }
    }
}
