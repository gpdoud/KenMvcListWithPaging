using System;
using System.ComponentModel.DataAnnotations;

namespace KenMvcListWithPaging.Models {

    public class Log {

        public int Id { get; set; }
        [StringLength(80)]
        public string Data { get; set; }

        public Log() {}
    }
}
