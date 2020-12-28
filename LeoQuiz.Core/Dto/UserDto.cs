namespace LeoQuiz.Core.Dto
{
    public class UserDto : IDto<string>
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public int UserRoleId { get; set; }
    }
}
