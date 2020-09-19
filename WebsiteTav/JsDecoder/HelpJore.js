//---> int id
//---> string Name
//---> string Email
//---> string Description


{
    return Bjax(Url.concat('/api/HelpCore/AddHelp'), help, 'LP');
}

{
    return Bjax(Url.concat('/api/HelpCore/DeleteHelp?id='), id, 'SP');
}

{
    var helpLogId = new Array();
    helpLogId.push(help);
    helpLogId.push(logId);
    return Bjax(Url.concat('/api/HelpCore/UpdateHelp'), helpLogId, 'LP');
}

{
    return Bjax(Url.concat('/api/HelpCore/SelectAllHelps'), '', 'G');
}

{
    return Bjax(Url.concat('/api/HelpCore/SelectHelpById?id='), id, 'SP');
}

{
    return Bjax(Url.concat('/api/HelpCore/SelectHelpByName?name='), name, 'SP');
}

{
    return Bjax(Url.concat('/api/HelpCore/SelectHelpByEmail?email='), email, 'SP');
}
