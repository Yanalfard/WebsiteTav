//---> int id
//---> string Name
//---> string TellNo

const Url = '';
function AddCoop(coop) {
    return Bjax(Url.concat('/api/CoopCore/AddCoop'), coop, 'LP');
}
function DeleteCoop(id) {
    return Bjax(Url.concat('/api/CoopCore/DeleteCoop?id='), id, 'SP');
}
function UpdateCoop(coop, logId) {
    var coopLogId = new Array();
    coopLogId.push(coop);
    coopLogId.push(logId);
    return Bjax(Url.concat('/api/CoopCore/UpdateCoop'), coopLogId, 'LP');
}
function SelectAllCoops() {
    return Bjax(Url.concat('/api/CoopCore/SelectAllCoops'), '', 'G');
}
function SelectCoopById(id) {
    return Bjax(Url.concat('/api/CoopCore/SelectCoopById?id='), id, 'SP');
}
function SelectCoopByName(name) {
    return Bjax(Url.concat('/api/CoopCore/SelectCoopByName?name='), name, 'SP');
}
function SelectCoopByTellNo(tellNo) {
    return Bjax(Url.concat('/api/CoopCore/SelectCoopByTellNo?tellNo='), tellNo, 'SP');
}
