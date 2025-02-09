﻿using MyRequest = Serenity.Services.SaveRequest<ProductPurchaseApp.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = ProductPurchaseApp.Administration.LanguageRow;


namespace ProductPurchaseApp.Administration;
public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
{
    public LanguageSaveHandler(IRequestContext context)
         : base(context)
    {
    }
}