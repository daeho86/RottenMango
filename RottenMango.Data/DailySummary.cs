//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 템플릿에서 생성되었습니다.
//
//     이 파일을 수동으로 변경하면 응용 프로그램에서 예기치 않은 동작이 발생할 수 있습니다.
//     이 파일을 수동으로 변경하면 코드가 다시 생성될 때 변경 내용을 덮어씁니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RottenMango.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class DailySummary
    {
        public int statisticId { get; set; }
        public string name { get; set; }
        public double avgMemory { get; set; }
        public double avgCPU { get; set; }
        public Nullable<DateTime> Date { get; set; }
    }
}