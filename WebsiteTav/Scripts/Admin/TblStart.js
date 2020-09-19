function LoadInStarts()
{
    const table = document.getElementById('tblMain');

    //---> int    id
    //---> string Name
    //---> string TellNo
    //---> string Description
    //---> string Brand
    //---> string SocialMediaLink
    //---> int    Status
    const helps = SelectAllStarts();

    debugger;
    for (const entry of helps)
    {
        table.innerHTML +=
            `
                <tr>
                    <td>${entry.id}</td>
                    <td>${entry.Name}</td>
                    <td>${entry.TellNo}</td>
                    <td>${entry.Description}</td>
                    <td>${entry.Brand}</td>
                    <td>${entry.SocialMediaLink}</td>
                    <td>${entry.Status}</td>
                </tr>   
                
            `;
    }
}

LoadInStarts();