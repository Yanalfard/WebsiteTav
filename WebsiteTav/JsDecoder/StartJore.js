//---> int    id
//---> string Name
//---> string TellNo
//---> string Description
//---> string Brand
//---> string SocialMediaLink
//---> int    Status


{
    return Bjax(Url.concat('/api/StartCore/AddStart'), start, 'LP');
}

{
    return Bjax(Url.concat('/api/StartCore/DeleteStart?id='), id, 'SP');
}

{
    var startLogId = new Array();
    startLogId.push(start);
    startLogId.push(logId);
    return Bjax(Url.concat('/api/StartCore/UpdateStart'), startLogId, 'LP');
}

{
    return Bjax(Url.concat('/api/StartCore/SelectAllStarts'), '', 'G');
}

{
    return Bjax(Url.concat('/api/StartCore/SelectStartById?id='), id, 'SP');
}

{
    return Bjax(Url.concat('/api/StartCore/SelectStartByName?name='), name, 'SP');
}

{
    return Bjax(Url.concat('/api/StartCore/SelectStartByTellNo?tellNo='), tellNo, 'SP');
}
