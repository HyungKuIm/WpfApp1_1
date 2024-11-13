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

    [Description("사용자 추가")]
    UserView,
}
