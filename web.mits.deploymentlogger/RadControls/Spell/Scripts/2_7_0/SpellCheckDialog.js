if (!Array.prototype.push){Array.prototype.push= function (){var I3=this.length; for (var i=0; i<arguments.length; i++){ this[I3+i]=arguments[i]; } ; return this.length; } ; } ; SpellDialog.o4=["\x63\x68\x61ngeB\x75tton","changeAll\x42\x75tto\x6e","\165\x6e\x64oButt\x6f\x6e","i\x67\x6eoreButt\x6f\x6e","igno\x72\x65AllBut\x74\x6fn","addC\x75\x73tomBut\x74\x6fn"]; function SpellDialog(O4){ this.window=O4; this.l4= false; this.i4= false; this.I4=""; this.o5=10; this.O5=0; this.l5=null; this.i5=null; this.I5=null; this.o6=[]; this.O6(); this.l6=new i6(this ); this.I6= false; this.o7= false; } ; SpellDialog.prototype.O6= function (){var O7= function (id,l7){return function (){return l7.i7(id); } ; } ; for (var i=0; i<SpellDialog.o4.length; i++){var I7=this ; var o8=SpellDialog.o4[i]; this[o8]=O7(o8,I7); } ; } ; SpellDialog.prototype.i7= function (O8){if (this["\142\x75tton_"+O8]==null){ this["butt\x6f\x6e_"+O8]=RadSpellWrappers.l8.i8(O8,this.document()); } ; return this["\x62utton_"+O8]; } ; SpellDialog.prototype.suggestions= function (){if (this.I8==null){ this.I8=RadSpellWrappers.o9.i8("sugge\x73\x74ions",this.document()); } ; return this.I8; } ; SpellDialog.prototype.document= function (){return this.window.document; } ; SpellDialog.prototype.O9= function (){return this.l5[this.O5];} ; SpellDialog.prototype.O2= function (id){if (this.document().all!=null){return this.document().all[id]; } ; return this.document().getElementById(id); } ; SpellDialog.prototype.arguments= function (){if (this.window.radWindow){return this.window.radWindow.Argument; } ; return null; } ; SpellDialog.prototype.queryStringParameters= function (){var w=/\x26\x51\x75\x65\x72\x79\x53\x74\x72\x69\x6e\x67\x50\x61\x72\x61\x6d\x65\x74\x65\x72\x73\x26(.*)$/; var V=w.exec(window.location.href); var l9=""; if (V!=null && V.length==2)l9=V[1]; else alert("Could not\x20\x65xtr\x61\x63t Qu\x65ryStrin\x67\120\x61\x72am\x65ter\x73"); return l9; } ; SpellDialog.prototype.isRadWindow= function (){if (!this.window.radWindow){return false; }else {return this.window.radWindow.UseRadWindow; } ; } ; SpellDialog.prototype.i9= function (){return this.I9(actionContainerID); } ; SpellDialog.prototype.I9= function (oa){var iframe=null; if (this.document().frames!=null && this.document().frames[oa]!=null){iframe=this.document().frames[oa]; } ; if (iframe==null){iframe=this.O2(oa); } ; if (iframe.document!=null){return iframe.document; }else {return iframe.contentWindow.document; } ; } ; SpellDialog.prototype.buttonAction= function (action,e){if (this.window.event==null){e.preventDefault(); e.stopPropagation(); } ; eval(action); return false; } ; SpellDialog.prototype.close= function (){if (this.window.radWindow){ this.window.radWindow.ReturnValue=null; this.window.radWindow.Close(); } ; } ; SpellDialog.prototype.startSpellingCheck= function (){ this.l6.Oa(this.window,localization.ProgressMessage); this.suggestions().la(); var ia=this.i9(); var Ia=ia.getElementById("\x74ext"); var ob=ia.getElementById("main\x46\x6frm"); if (Ia==null){var self=this ; window.setTimeout( function (){self.startSpellingCheck(); } ,100); } this.Ob=this.arguments(); this.lb=this.Ob.L(); try { this.I4=RadSpellNamespace.ib(this.lb.getText()); }catch (P){alert("\x45rror\x20\x69n get\x54\x65xt(\x29\072\x20"+P.message); }Ia.value=this.Ib(this.I4); ob.submit(); this.oc(); } ; SpellDialog.prototype.oc= function (){var dialog=this ; var Oc=this.window.radWindow; var lc= function (){if (dialog.I6== true)return; dialog.I6= true; var Ob=dialog.Ob; dialog.Ob.B(); Oc.ic(); var Ic= function (){if (Ob.spellChecked()!= true){Ob.c(); }else {Ob.C(); }};Ob.window.setTimeout(Ic,100); } ; if (Oc!=null){Oc.ic=this.window.radWindow.Close; Oc.Close=lc; this.window.onunload=lc; }} ; SpellDialog.prototype.od= function (){try {if (this.o7)this.lb.setText(RadSpellNamespace.Od(this.I4)); }catch (P){alert("\x45rror\x20\x69n se\x74\x54ext\x28\051\x3a\040"+P.message); } this.Ob.setSpellChecked( true); alert(localization.SpellCheckComplete); this.close(); } ; SpellDialog.prototype.cancelCheck= function (){if (this.i4 && confirm(localization.Confirm)){ this.od(); }else { this.close(); } ; } ; SpellDialog.prototype.ld= function (oe,Oe){for (i=oe; i<this.i5.length; i++){ this.i5[i]+=Oe; } ; } ; SpellDialog.prototype.customWordAdded= function (le,ie){for (var i=this.O5; i<this.l5.length; i++){if (this.O9().wordString==this.l5[i].wordString){ this.l5[i].isFixed= true; } ; } ; this.Ie(); } ; SpellDialog.prototype.serverError= function (message){alert(message); } ; SpellDialog.prototype.actionReady= function (of,Of){var l7=this ; var If= function (){l7.og(); } ; if (!this.l6.Og()){return; } ; if ((Of!=null) && (of!=null)){ this.i5=of; this.l5=Of; if (this.l5.length>0){ this.l6.lg(If); if (!this.Ie()){return; } ; this.suggestions().Ig.focus(); }else { this.od(); } ; } ; } ; SpellDialog.prototype.oh= function (){ this.suggestions().Oh(); if (!this.O9().suggestionsString || (this.O9().suggestionsString.length==0)){ this.suggestions().lh(localization.Nosuggestions,""); this.changeButton().la(); this.changeAllButton().la(); }else {for (var i=0; i<this.O9().suggestionsString.length; i++){var ih=this.O9().suggestionsString[i]; this.suggestions().lh(ih,ih); } ; } ; this.suggestions().Ih(0); } ; SpellDialog.prototype.addCustom= function (){if (!this.l4){if (!confirm(localization.AddWord1+this.O9().wordString+localization.AddWord2)){return; } ; this.Ob.I1(this.O9().wordString); var ia=this.i9(); ia.getElementById("\143ustomWord").value=this.O9().wordString; ia.getElementById("\x6dainFo\x72\x6d").submit(); }else {alert(localization.ChangesMade); } ; } ; SpellDialog.prototype.oi= function (){var selected=this.suggestions().Oi(); if (selected==-1)return null; var option=this.suggestions().getItem(selected); if (option==null)return null; else return option.value; };SpellDialog.prototype.ii= function (i){var Ii=0; var oj=new Object(); var l0=""; if (!this.l4){var Oj=this.oi(); if (Oj==null){return false; }if (Oj!=""){l0=Oj; }else {alert(localization.Nosuggestions); return false; } ; }else { this.ignoreButton().lj("<span>"+localization.Ignore+"<spa\x6e>"); l0=this.l6.getText(); } ; var ij=this.I4.substring(0,this.i5[this.l5[i].textOffset]); var Ij=this.I4.substring(this.i5[this.l5[i].textOffset]+this.l5[i].wordString.length,this.I4.length); this.I4=ij+l0+Ij; Ii+=l0.length-this.l5[i].wordString.length; oj.ok=this.i5[this.l5[i].textOffset]; oj.Ok=oj.ok+l0.length; oj.lk=this.l5[i].wordString; oj.ik=i; oj.Oe=-Ii; this.I5.Ik[this.I5.Ik.length]=oj; if (Ii!=0){ this.ld(this.l5[i].textOffset,Ii); } this.i4= true; this.l5[i].isFixed= true; this.o7= true; return true; } ; SpellDialog.prototype.ll= function (oj){var ok=oj.ok; var Ok=oj.Ok; var ik=oj.ik; var il=oj.lk; var Oe=oj.Oe; this.I4=this.I4.substring(0,ok)+il+this.I4.substring(Ok,this.I4.length); if (Oe!=0){ this.ld(this.l5[ik].textOffset,Oe); } ; this.l5[ik].isFixed= false; } ; SpellDialog.prototype.changeWord= function (){if (this.ii(this.O5)){var Oj=this.oi(); if (Oj==null)Oj=this.l6.getText(); var Il=this.om(this.i5[this.O9().textOffset]); this.Ob.o0(this.O9().wordString,Oj,[Il], false); this.I5.O5=this.O5; this.I5.action="c"; this.o6.push(this.I5); } ; this.Ie(); } ; SpellDialog.prototype.om= function (Il){var Om=this.I4.substring(0,Il); var Im=RadSpellNamespace.Od(Om); return Im.length; };SpellDialog.prototype.On= function (O2){var oj=O2.Ik[O2.Ik.length-1]; O2.Ik=O2.Ik.slice(0,-1); var ok=oj.ok; var Ok=oj.Ok; var lk=oj.lk; var om=this.om(ok); var l0=this.I4.substring(ok,Ok); this.Ob.I0(lk,l0,[om], false); this.ll(oj); this.O5=O2.O5; this.Ie(); } ; SpellDialog.prototype.changeAll= function (){var selected=this.suggestions().Oi(); var option=this.suggestions().getItem(selected); if (option.value==""){ this.changeWord(); }else {var Oj=this.oi(); if (Oj==null)Oj=this.l6.getText(); var i0=[]; for (var i=this.O5; i<this.l5.length; i++){if (this.l5[i].wordString==this.O9().wordString){var In=this.om(this.i5[this.l5[i].textOffset]); i0.push(In); dialog.ii(i); } ; } ; this.Ob.o0(this.O9().wordString,Oj,i0, true); this.I5.O5=this.O5; this.I5.action="C"; this.o6.push(this.I5); this.Ie(); } ; } ; SpellDialog.prototype.oo= function (O2){var l0=""; var i0=[]; for (var i=this.l5.length-1; i>=O2.O5; i--){if (this.l5[i].wordString==this.l5[O2.O5].wordString){var oj=O2.Ik[O2.Ik.length-1]; var ok=oj.ok; var Ok=oj.Ok; var om=this.om(ok); i0.push(om); if (l0==""){lk=oj.lk; l0=this.I4.substring(ok,Ok); }O2.Ik=O2.Ik.slice(0,-1); this.ll(oj); } ; } ; this.Ob.I0(lk,l0,i0, false); this.O5=O2.O5; this.Ie(); } ; SpellDialog.prototype.ignoreAll= function (){var i0=[]; for (var i=this.O5; i<this.l5.length; i++){if (this.l5[i].wordString==this.O9().wordString){var In=this.om(this.i5[this.l5[i].textOffset]); i0.push(In); this.l5[i].isFixed= true; } ; } ; this.Ob.l1(this.O9().wordString,i0, true); this.I5.O5=this.O5; this.I5.action="I"; this.o6.push(this.I5); this.Ie(); } ; SpellDialog.prototype.Oo= function (oe){var i0=[]; for (var i=this.l5.length-1; i>=oe; i--){if (this.l5[i].wordString==this.l5[oe].wordString){ this.l5[i].isFixed= false; var om=this.om(this.i5[this.l5[i].textOffset]); i0.push(om); } ; } ; this.Ob.O1(this.l5[oe].wordString,i0, true); this.O5=oe; this.Ie(); } ; SpellDialog.prototype.Io= function (oe){if (!this.l4){ this.l5[oe].isFixed= false; var om=this.om(this.i5[this.l5[oe].textOffset]); this.Ob.O1(this.l5[oe].wordString,[om], false); this.O5=oe; }else { this.ignoreButton().lj("<span>"+localization.Ignore+"</span\x3e"); } ; this.Ie(); } ; SpellDialog.prototype.ignoreWord= function (){if (!this.l4){var In=this.om(this.i5[this.O9().textOffset]); this.Ob.l1(this.O9().wordString,[In], false); this.O9().isFixed= true; this.I5.O5=this.O5; this.I5.action="i"; this.o6.push(this.I5); }else { this.ignoreButton().lj("<span>"+localization.Ignore+"\x3c/span>"); } ; this.Ie(); } ; SpellDialog.prototype.undoLast= function (){if (this.o6.length>0){var O2=this.o6[this.o6.length-1]; this.o6=this.o6.slice(0,-1); switch (O2.action){case "a":break; case "i": this.Io(O2.O5); break; case "\x49": this.Oo(O2.O5); break; case "c": this.On(O2); break; case "C": this.oo(O2); break; default:} ; }else { this.undoButton().la(); } ; } ; SpellDialog.prototype.og= function (){if (!this.l4){ this.l4= true; this.l6.op( true); this.l6.Op(); this.l6.setText(this.O9().wordString); this.suggestions().Ih(-1); this.suggestions().la(); this.changeButton().Oh(); this.ignoreButton().Oh(); this.ignoreButton().lj("<sp\x61\x6e>"+localization.UndoEdit+"\x3c/span>"); this.ignoreAllButton().la(); this.changeAllButton().la(); if (this.addCustomButton()!=null){ this.addCustomButton().la(); } ; } ; } ; SpellDialog.prototype.Ie= function (){ this.I5=new Object(); this.I5.Ik=new Array(); if (this.o6.length>0){ this.undoButton().Oh(); }else { this.undoButton().la(); } ; while (this.O5<this.l5.length && this.O9().isFixed){ this.O5++; } ; this.l4= false; this.l6.op( false); this.ignoreButton().Oh(); this.ignoreAllButton().Oh(); if (this.addCustomButton()!=null){ this.addCustomButton().Oh(); } ; this.changeButton().Oh(); this.changeAllButton().Oh(); this.suggestions().lp(); if (this.O5==this.l5.length){ this.od(); }else { this.l6.ip(); try { this.l6.Ip(); }catch (P){return false; } ; this.oh(); } ; return true; } ; SpellDialog.prototype.Ib= function (oq){var Oq=new Array("\045"," ","!","\x22","#","\x24","\x26","\x27","(",")",",",":",";","\x3c","\x3d","\x3e","?","\x5b","\134","\x5d","\x5e","`","\x7b","\x7c","\x7d","\176"); for (var i=0; i<Oq.length; i++){oq=oq.replace(new RegExp("\134\x78"+Oq[i].charCodeAt(0).toString(16),"ig"),escape(Oq[i])); } ; return oq.replace(/\x2b/ig,"%2B"); } ; function i6(lq){ this.dialog=lq; this.ownerDocument=this.dialog.document(); this.iq=null; this.Iq= false; } ; i6.prototype.display= function (){if (this.or==null){ this.or=RadSpellWrappers.Or.i8("\x74extDisplay",this.ownerDocument); } ; return this.or; } ; i6.prototype.Oa= function (lr,ir){ this.window=lr; this.setText(ir); } ; i6.prototype.lg= function (Ir){ this.display().os(Ir); } ; i6.prototype.Og= function (){return this.display()!=null; };i6.prototype.Os= function (id){var anchors=this.display().Ig.getElementsByTagName("a"); for (var i=0; i<anchors.length; i++){var anchor=anchors[i]; if (anchor.id=="\x73pe\x6c\x6c_high\x6c\151\x67\x68t\x5f"+id)return anchor; }return null; };i6.prototype.ip= function (){var ls=(this.dialog.O9().textOffset-this.dialog.o5>0?this.dialog.i5[this.dialog.O9().textOffset-this.dialog.o5]: 0); var is=this.dialog.i5[this.dialog.O9().textOffset]; var Is=is+this.dialog.O9().wordString.length; var ot=(this.dialog.O9().textOffset+this.dialog.o5<this.dialog.i5.length?this.dialog.i5[this.dialog.O9().textOffset+this.dialog.o5]: this.dialog.I4.length); var Ot=this.dialog.I4.substring(ls,is); var lt=this.dialog.I4.substring(Is,ot)+"<br /><br \x2f\x3e"; var it=Ot+"\x3c\x61 styl\x65\x3d\047\142or\x64er-bott\x6f\155:\x20\x31px \x64\x6ftte\x64\040r\x65d;fon\x74\055w\x65ight:\x20bold;\x27 id=\x27sp\x65ll_h\x69ghli\x67ht_"+this.dialog.O9().wordString+"\x27\x3e"+this.dialog.O9().wordString+"\x3c/a>"+lt; this.setText(it); } ; i6.prototype.Ip= function (){var It=this.Os(this.dialog.O9().wordString); if (It!=null){if (this.dialog.isRadWindow()== false && It.scrollIntoView!=null){It.scrollIntoView(); }else { this.or.Ig.scrollTop=It.offsetTop; It.focus(); }} ; };i6.prototype.Op= function (){ this.iq.Ig.focus(); };i6.prototype.setText= function (text){if (this.iq!=null){ this.iq.setText(text); }else { this.display().setText(text); } ; } ; i6.prototype.getText= function (text){if (this.iq!=null){return this.iq.getText(); }else {return this.display().getText(); } ; } ; i6.prototype.op= function (ou){ this.Iq=ou; if (this.Iq== true){ this.Ou(); }else { this.lu(); } ; } ; i6.prototype.Ou= function (){ this.iq=this.iu(); } ; i6.prototype.lu= function (){if (this.iq!=null){ this.iq.Iu("n\x6fne"); this.display().Iu("\x62lock"); this.iq=null; } ; } ; i6.prototype.ov= function (){return this.Iq; } ; i6.prototype.iu= function (){var iq=RadSpellWrappers.Ov.i8("\x63ontentTextA\x72ea",this.ownerDocument); this.display().Iu("none"); iq.Iu("\x69nline"); return iq; } ;