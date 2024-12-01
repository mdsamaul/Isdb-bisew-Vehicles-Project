$(document).ready(() => {
    $(".clearPickupBtn").click(() => {
        $(".pickup-location").val('');
    });
    $(".clearDropoffBtn").click(() => {
        $(".dropoff-location").val('');
    });
    function getCurrentTime() {
        let currentTime = new Date();
        let hours = currentTime.getHours().toString().padStart(2, '0');
        let minutes = currentTime.getMinutes().toString().padStart(2, '0');
        return hours + ':' + minutes;
    }
    $("#timePicker").focus(() => {
        $("#timePicker").val(getCurrentTime());
    });
    $(".singinbtn").click((e) => {
        e.preventDefault();
        $(".entyPersonContainer").show();
    });
    $(".singupBtn").click((e) => {
        e.preventDefault();
        $(".entyPersonContainer").show();
    });
    $(".closeSectionBtn").click((e) => {
        e.preventDefault();
        $(".entyPersonContainer").hide();
    });
});


