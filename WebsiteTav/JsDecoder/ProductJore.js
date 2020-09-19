//---> int id
//---> string Name
//---> string TellNo
//---> string Address
//---> string ProductName
const Url = '';
function AddProduct(product)
{
    return Bjax(Url.concat('/api/ProductCore/AddProduct'), product, 'LP');
}
function DeleteProduct(id)
{
    return Bjax(Url.concat('/api/ProductCore/DeleteProduct?id='), id, 'SP');
}
function UpdateProduct(product, logId)
{
    var productLogId = new Array();
    productLogId.push(product);
    productLogId.push(logId);
    return Bjax(Url.concat('/api/ProductCore/UpdateProduct'), productLogId, 'LP');
}
function SelectAllProducts()
{
    return Bjax(Url.concat('/api/ProductCore/SelectAllProducts'), '', 'G');
}
function SelectProductById(id)
{
    return Bjax(Url.concat('/api/ProductCore/SelectProductById?id='), id, 'SP');
}
function SelectProductByName(name)
{
    return Bjax(Url.concat('/api/ProductCore/SelectProductByName?name='), name, 'SP');
}
function SelectProductByTellNo(tellNo)
{
    return Bjax(Url.concat('/api/ProductCore/SelectProductByTellNo?tellNo='), tellNo, 'SP');
}
function SelectProductByProductName(productName)
{
    return Bjax(Url.concat('/api/ProductCore/SelectProductByProductName?productName='), productName, 'SP');
}
