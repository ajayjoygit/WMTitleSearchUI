const selectElement = document.querySelector('.title-search');
      selectElement.addEventListener(
                                     'keypress',
                                     getTitlesFromWebApi,
                                     false
                                    );

function getTitlesFromWebApi(e) {
    var searchTitle = e.target.value;
    var url = "http://localhost:5555/api/"+searchTitle;
    var xmlHttp = new XMLHttpRequest();

    xmlHttp.open("GET", url, false);
    xmlHttp.send(null);
    console.log(xmlHttp.responseText);
    return xmlHttp.responseText;
}

 
