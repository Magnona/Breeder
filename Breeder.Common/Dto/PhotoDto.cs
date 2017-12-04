using System;
namespace Breeder.Common.Dto
{
    public class PhotoDto
    {
        public int Id { get; set; }
        public bool IsKeyPhoto { get; set; }
        public string FileName { get; set; }
        public string FileLink { get; set; }
        public int Order { get; set; }
        public int PetId { get; set; }
    }
}
