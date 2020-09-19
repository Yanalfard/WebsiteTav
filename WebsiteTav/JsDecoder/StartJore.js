//---> int    id
//---> string Name
//---> string TellNo
//---> string Description
//---> string Brand
//---> string SocialMediaLink
//---> int    Status
const Url = '';
function AddStart(start)
{
    return Bjax(Url.concat('/api/StartCore/AddStart'), start, 'LP');
}
function DeleteStart(id)
{
    return Bjax(Url.concat('/api/StartCore/DeleteStart?id='), id, 'SP');
}
function UpdateStart(start, logId)
{
    var startLogId = new Array();
    startLogId.push(start);
    startLogId.push(logId);
    return Bjax(Url.concat('/api/StartCore/UpdateStart'), startLogId, 'LP');
}
function SelectAllStarts()
{
    return Bjax(Url.concat('/api/StartCore/SelectAllStarts'), '', 'G');
}
function SelectStartById(id)
{
    return Bjax(Url.concat('/api/StartCore/SelectStartById?id='), id, 'SP');
}
function SelectStartByName(name)
{
    return Bjax(Url.concat('/api/StartCore/SelectStartByName?name='), name, 'SP');
}
function SelectStartByTellNo(tellNo)
{
    return Bjax(Url.concat('/api/StartCore/SelectStartByTellNo?tellNo='), tellNo, 'SP');
}
