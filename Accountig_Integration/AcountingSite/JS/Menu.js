
var Menu = {
    init: function () {

        Menu.PageEvent();
        Menu.PageReset();
        $("#inicioM").show();
    },

PageEvent: function () {
        Menu.PageEventInicio();
        Menu.PageEventHomTipoDoc();
        Menu.PageEventHomCuentaC();
        Menu.PageEventayuda();
      //  Menu.PageSaldosDiarios();
        Menu.PageAuditoria();
       // Menu.PageCXC();
       Menu.PageIngresos_cxc();
    },
 PageReset: function () {          
            $("#inicioM").hide();
            $("#HomTipoDocM").hide();
            $("#HomCuentasContableM").hide();
            $("#SaldosDiariosM").hide();
            $("#CXCM").hide();
            $("#IngresosCXCM").hide();
            $("#AuditoriaM").hide();
            $("#ayudaM").hide();        
    },

 PageEventInicio: function () {
           $("#inicio").click(function () {
             debugger;
            Menu.PageReset();
            $("#inicioM").show();
         });
    },
 PageEventHomTipoDoc: function () {
           $("#HomTipoDoc").click(function () {
           Menu.PageReset();
          $("#HomTipoDocM").show();
          Acount_Tipo_DOC.HomTipeDocGrid();
         });

    },
 PageEventHomCuentaC: function () {
           $("#HomCuentaC").click(function () {
            Menu.PageReset();
               $("#HomCuentasContableM").show();
               Acount_Cuentas.HomCuentasGrid();
         });
    },
 //PageSaldosDiarios: function () {
         //  $("#SaldosDiarios").click(function () {
          //  Menu.PageReset();
          //     $("#SaldosDiariosM").show();
           //    Int_Saldos.Int_saldosALL();
        // });
   // },
 PageAuditoria: function () {
           $("#Auditoria").click(function () {
            Menu.PageReset();
               $("#AuditoriaM").show();
               Int_Auditoria.Int_AuditoriaALL();
         });
    },
 //PageCXC: function () {
        //   $("#CXC").click(function () {
        //    Menu.PageReset();
        //       $("#CXCM").show();
             //  Int_CXC.Int_CXCALL();
       //  });
  //  },
 PageEventayuda: function () {
         $("#ayuda").click(function () {
          Menu.PageReset();
         $("#ayudaM").show();
         });
    },
PageIngresos_cxc: function () {
           $("#IngresosCXC").click(function () {
            Menu.PageReset();
               $("#IngresosCXCM").show();
               Int_Ingresos_CXC.Int_Ingresos_cxcALL();
         });
    }
};

$(document).ready(function () {
    Menu.init();
});
