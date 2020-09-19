function LoadInHelps()
{
    const table = document.getElementById('tblMain');

    //---> int id
    //---> string Name
    //---> string Email
    //---> string Description
    const helps = SelectAllHelps();

    for (const entry of helps)
    {
        table.innerHTML +=
            `
                <tr>
                    <td>${entry.id}</td>
                    <td>${entry.Name}</td>
                    <td>${entry.Email}</td>
                    <td>${entry.Description}</td>
                </tr>   
                
            `;
    }
}

LoadInHelps();