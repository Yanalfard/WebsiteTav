//---> int id
//---> string Name
//---> string TellNo

const Url = '';

    return Bjax(Url.concat('/api/CoopCore/AddCoop'), coop, 'LP');
}

    return Bjax(Url.concat('/api/CoopCore/DeleteCoop?id='), id, 'SP');
}

    var coopLogId = new Array();
    coopLogId.push(coop);
    coopLogId.push(logId);
    return Bjax(Url.concat('/api/CoopCore/UpdateCoop'), coopLogId, 'LP');
}

    return Bjax(Url.concat('/api/CoopCore/SelectAllCoops'), '', 'G');
}

    return Bjax(Url.concat('/api/CoopCore/SelectCoopById?id='), id, 'SP');
}

    return Bjax(Url.concat('/api/CoopCore/SelectCoopByName?name='), name, 'SP');
}

    return Bjax(Url.concat('/api/CoopCore/SelectCoopByTellNo?tellNo='), tellNo, 'SP');
}
