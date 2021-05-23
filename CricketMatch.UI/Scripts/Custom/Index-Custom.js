function KillModal() {
    $('#addplayerModal').modal('toggle');
    $('#playerName').val('0');
    $('#playerType').val('0');
    $('#playerPosition').val('');
    $('#playerTeam').val('0');
    
}

var myplayers = { rows: [{ name: "Virat", type: "Batsmen", position: "Position", team: "TeamA" }] }
$(function () {
    $("#playerTab").jqGrid({
        datatype: "json",
        colNames: ['Name', 'Type', 'Position', 'Team','Actions'],
        colModel: [
            { name: 'name', index: 'name', width: 55, editable: true },
            { name: 'type', index: 'type', width: 90, editable: true},
            { name: 'position', index: 'position', width: 100, editable: true },
            { name: 'team', index: 'team', width: 80, editable: true },
            {
                name: 'actions', index: 'actions', width: 100,
                formatter: 'actions',
                formatoptions: {
                    keys: false,
                    editbutton: false,
                    delbutton: true,
                    editformbutton: true,
                    extraparam: { oper: 'edit' },
                }
            }
        ],
        //rowNum: 10,
        //rowList: [10, 20, 30],
        //pager: '#pager2',
        sortname: 'id',
        viewrecords: true,
        sortorder: "desc",
        caption: "Players"
    });

});

function AddPlayer() {
    var player = {
        name: $("#playerName").val(), type: $("#playerType").val(), position: $("#playerPosition").val(),
        team: $("#playerTeam").val()
    };
    jQuery("#playerTab").jqGrid('addRowData', 1, player);
    KillModal();
}