#pragma checksum "C:\THEgame\THEgame\THEgame\Views\Home\Rules.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ea6ab7244296b67e7ad033d891ce4dc78598871"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Rules), @"mvc.1.0.view", @"/Views/Home/Rules.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\THEgame\THEgame\THEgame\Views\_ViewImports.cshtml"
using THEgame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\THEgame\THEgame\THEgame\Views\_ViewImports.cshtml"
using THEgame.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ea6ab7244296b67e7ad033d891ce4dc78598871", @"/Views/Home/Rules.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5a0de58f6f78d56e10492fe8c4bacb248245b83", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Rules : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\THEgame\THEgame\THEgame\Views\Home\Rules.cshtml"
  
    ViewData["Title"] = "Добро пожаловать в Weedgrowing!";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""rulesflex"">
    <h3>Создание персонажа</h3>
    <ul class=""rules"">
        <li>Создайте свой личный аккаунт (логин | пароль)</li>
        <li>Авторизируйтесь на сайте игры.</li>
        <li>Создайте персонажа, нажав на иконку линка.</li>
        <li>Выберите ""Основные параметры"" Вашего персонажа.</li>
        <li>
            Такие параметры, как ""Пол персонажа"" , ""Речь персонажа"" и ""Раса"" будут
            положительно или негативно сказываться как на выборе характеристик так и
            на весь игровой процесс в целом!
        </li>
        <li>
            Распределите очки характеристик в поле ""Характеристики""
            (Влияет на стартовые навыки/репутацию/выбор специализации)
        </li>
        <li>Выберите стартовые навыки в поле ""Навыки""</li>
        <li>Сохраните Ваши изменения!</li>
        <li>Перейдите в стартовую локацию (кнопка ""В локацию"")</li>
    </ul>
    <h4>Weedgrowing - это ""будет"" большой мир, который вы создадите сами!</h4>

    <h3>Торговля</h3>");
            WriteLiteral(@"

    <h4>Валюта:</h4>
    <div>
        Изначально в игре нет денег (совсем)
        -Как же тут что-либо покупать или продавать? - спросите Вы
    </div>
    <ul class=""rules"">
        <li>Бартер система</li>
        <li>
            Кузнецы могут выковать 4 типа монет - ""Золотая"", ""Серебряная"", ""Бронзовая"", ""Фальшивая"".
            Для первых трех типов Вам понадобятся золотая, серебряная и бронзовая руда соответственно.
        </li>

        Здесь нет монстров, которые съели мешок золота и ждут когда вы придете за ними! (или есть?)

        -Я что должен все делать сам что-ли?
        -Да, на это и расчитана игра!
    </ul>
    <div class=""rulesimg"">
    </div>
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
