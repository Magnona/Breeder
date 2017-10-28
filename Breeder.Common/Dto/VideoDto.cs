using System;
namespace Breeder.Common.Dto
{
    public class VideoDto
    {
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string VideoLink { get; set; }
        public int Order { get; set; }
        public Guid PetId { get; set; }
    }
}
