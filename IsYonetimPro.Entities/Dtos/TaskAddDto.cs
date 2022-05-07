using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsYonetimPro.Entities.Dtos
{
    public class TaskAddDto
    {
        [DisplayName("İş Başlığı")]
        [Required(ErrorMessage = "{0} Boş Geçilmemelidir.")]//display name de dne yazıyorsa {0}buraya eklenicek.
        [MaxLength(50, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]//dinamik kullandık tekrar tekrar yazmamak için
        public string TaskTitle { get; set; }
        [DisplayName("İş Açıklaması")]
        [Required(ErrorMessage = "{0} Boş Geçilmemelidir.")]//display name de dne yazıyorsa {0}buraya eklenicek.
        public string TaskDescription { get; set; }
        [DisplayName("İş Başlangıç Tarihi")]
        public DateTime? TaskStartDate { get; set; }
        [DisplayName("İş Bitiş Tarihi")]
        public DateTime? TaskEndDate { get; set; }
        public int TaskDepartmentId { get; set; }
        [DisplayName("İşin Önem Düzeyi")]
        [Required(ErrorMessage = "{0} Boş Geçilmemelidir.")]
        public int TaskImportanceId { get; set; }
        [DisplayName("İşin Durumu")]
        [Required(ErrorMessage = "{0} Boş Geçilmemelidir.")]
        public int TaskStatusId { get; set; }
        [DisplayName("İşin Ait Olduğu Proje")]
        [Required(ErrorMessage = "{0} Boş Geçilmemelidir.")]
        public int ProjectId { get; set; }
        
    }
}
