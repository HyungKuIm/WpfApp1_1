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
    WpfDataBinding,

    [Description("컨트롤템플릿 샘플")]
    ControlTemplateView,

    [Description("리소스 연습")]
    ResourceTestView,

    [Description("캘린더(유니폼그리드)")]
    CalendarView,

    [Description("애니메이션 연습")]
    AnimationTestView,

    [Description("라우트이벤트 연습")]
    RoutedEventTestView,

    [Description("커맨드 뷰 연습")]
    CommandView,

    [Description("사용자추가 연습")]
    UserView,

    [Description("의존 프로퍼티 연습")]
    DependencyPropertyTest,

    [Description("아이템즈컨트롤 연습")]
    AllUsersView,

    [Description("메뉴 연습")]
    KBOView,

    [Description("어벤져스")]
    AvengersView,

}
