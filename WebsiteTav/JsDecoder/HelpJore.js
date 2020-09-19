//---> int id
//---> string Name
//---> string Email
//---> string Description
const Url = '';
function AddHelp(help)
{
    return Bjax(Url.concat('/api/HelpCore/AddHelp'), help, 'LP');
}
function DeleteHelp(id)
{
    return Bjax(Url.concat('/api/HelpCore/DeleteHelp?id='), id, 'SP');
}
function UpdateHelp(help, logId)
{
    var helpLogId = new Array();
    helpLogId.push(help);
    helpLogId.push(logId);
    return Bjax(Url.concat('/api/HelpCore/UpdateHelp'), helpLogId, 'LP');
}
function SelectAllHelps()
{
    return Bjax(Url.concat('/api/HelpCore/SelectAllHelps'), '', 'G');
}
function SelectHelpById(id)
{
    return Bjax(Url.concat('/api/HelpCore/SelectHelpById?id='), id, 'SP');
}
function SelectHelpByName(name)
{
    return Bjax(Url.concat('/api/HelpCore/SelectHelpByName?name='), name, 'SP');
}
function SelectHelpByEmail(email)
{
    return Bjax(Url.concat('/api/HelpCore/SelectHelpByEmail?email='), email, 'SP');
}
