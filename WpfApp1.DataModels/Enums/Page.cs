using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DataModels.Enums;
public enum Page
{
    [Description("강사 소개")]
    StartView,

    [Description("고양이 소라군 소개")]
    SoraView,

    [Description("임형구 소개")]
    HKView,

    [Description("그리드 샘플")]
    WpfGridSample,

    [Description("데이터바인딩 샘플")]
    WpfDataBinding

}
