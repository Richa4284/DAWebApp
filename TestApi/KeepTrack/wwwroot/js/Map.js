// Initialize and add the map 
function initMap() { 
     
    var map = new google.maps.Map( 
        document.getElementById('map'), 
        {
            zoom: 12, 
            center: { lat: 23.18732066018282, lng: 72.62799994541567}
        }
    );

    var Daiict = new google.maps.Marker({ position: { lat: 23.187320, lng: 72.627999 }, map: map });
    var Sargasan = new google.maps.Marker({ position: { lat: 23.185640, lng: 72.602837 }, map: map });

    //For Daiict
    var ContDaiict = '<div id="content">' +
        '<div id="siteNotice">' +
        '</div>' +
        '<h1 id="firstHeading" >DAIICT</h1>' +
        '<div id="bodyContent">' +
        '<p><b>DAIICT</b>, also referred to as <b>Ayers Rock</b>, is a large ' +
        'sandstone rock formation in the southern part of the ' +
        'Northern Territory, central Australia. It lies 335&#160;km (208&#160;mi) ' +
        'south west of the nearest large town, Alice Springs; 450&#160;km ' ;

    var DaWin = new google.maps.InfoWindow({
        content: ContDaiict
    });

    Daiict.addListener('mouseover', function () {
        DaWin.open(map, Daiict);
    });

    Daiict.addListener('mouseout', function () {
        DaWin.close();
    });

    //Saragasan

    var ContSargasan= '<div id="content">' +
        '<div id="siteNotice">' +
        '</div>' +
        '<h1 id="firstHeading" >Sargasan</h1>' +
        '<div id="bodyContent">' +
        '<p><b>Sargasan</b>, also referred to as <b>Ayers Rock</b>, is a large ' +
        'sandstone rock formation in the southern part of the ' +
        'Northern Territory, central Australia. It lies 335&#160;km (208&#160;mi) ' +
        'south west of the nearest large town, Alice Springs; 450&#160;km ';

    var SargasanWin = new google.maps.InfoWindow({
        content: ContSargasan
    });

    Sargasan.addListener('mouseover', function () {
        SargasanWin.open(map, Sargasan);
    });

    Sargasan.addListener('mouseout', function () {
        SargasanWin.close();
    });
}
