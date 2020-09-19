function LoadInCoops()
{
    const table = document.getElementById('tblMain');

    //---> int id
    //---> string Name
    //---> string TellNo
    const helps = SelectAllCoops();

    for (const entry of helps)
    {
        table.innerHTML +=
            `
                <tr>
                    <td>${entry.id}</td>
                    <td>${entry.Name}</td>
                    <td>${entry.TellNo}</td>
                </tr>   
            `;
    }
}

LoadInCoops();