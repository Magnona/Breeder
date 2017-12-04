using System;
namespace Breeder.Common.Dto
{
    public class VideoDto
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string VideoLink { get; set; }
        public int Order { get; set; }
        public int PetId { get; set; }
    }
}
