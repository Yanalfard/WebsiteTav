//---> int id
//---> string Name
//---> string TellNo
//---> string Address
//---> string ProductName


{
    return Bjax(Url.concat('/api/ProductCore/AddProduct'), product, 'LP');
}

{
    return Bjax(Url.concat('/api/ProductCore/DeleteProduct?id='), id, 'SP');
}

{
    var productLogId = new Array();
    productLogId.push(product);
    productLogId.push(logId);
    return Bjax(Url.concat('/api/ProductCore/UpdateProduct'), productLogId, 'LP');
}

{
    return Bjax(Url.concat('/api/ProductCore/SelectAllProducts'), '', 'G');
}

{
    return Bjax(Url.concat('/api/ProductCore/SelectProductById?id='), id, 'SP');
}

{
    return Bjax(Url.concat('/api/ProductCore/SelectProductByName?name='), name, 'SP');
}

{
    return Bjax(Url.concat('/api/ProductCore/SelectProductByTellNo?tellNo='), tellNo, 'SP');
}

{
    return Bjax(Url.concat('/api/ProductCore/SelectProductByProductName?productName='), productName, 'SP');
}
