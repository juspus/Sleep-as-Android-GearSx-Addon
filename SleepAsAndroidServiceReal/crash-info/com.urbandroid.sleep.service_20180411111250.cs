S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.7
Build-Number: R732XXU2FRC1
Build-Date: 2018.03.02 17:21:30

Crash Information
Process Name: sleepasandroidnativeservice
PID: 24828
Date: 2018-04-11 11:12:50+0200
Executable File Path: /opt/usr/apps/com.urbandroid.sleep/bin/sleepasandroidnativeservice
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xb923

Register Information
r0   = 0x00000000, r1   = 0x0000b923
r2   = 0x00000008, r3   = 0x430bc9c0
r4   = 0x430bc9e0, r5   = 0x430be248
r6   = 0x0000b923, r7   = 0xbefd7eb0
r8   = 0x0000ba93, r9   = 0x0000ba93
r10  = 0x430acec8, fp   = 0x00000000
ip   = 0x430cb030, sp   = 0xbefd7e20
lr   = 0x40296651, pc   = 0x4000215e
cpsr = 0x40000030

Memory Information
MemTotal:   490112 KB
MemFree:     14968 KB
Buffers:     10340 KB
Cached:     112744 KB
VmPeak:      60288 KB
VmSize:      60284 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        8912 KB
VmRSS:        8912 KB
VmData:      11256 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       19584 KB
VmPTE:          32 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 24828 TID = 24828
24828 24849 

Maps Information
40000000 40005000 r-xp /opt/usr/apps/com.urbandroid.sleep/bin/sleepasandroidnativeservice
40007000 4000b000 r-xp /usr/lib/libsys-assert.so
40016000 40033000 r-xp /lib/ld-2.13.so
40052000 40055000 r-xp /usr/lib/libappcore-agent.so.1.1
4005d000 4005f000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
40068000 4006c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
40075000 4007a000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
40082000 4008e000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
40097000 40099000 r-xp /usr/lib/libdlog.so.0.0.0
400a1000 400b8000 r-xp /usr/lib/libecore.so.1.7.99
400cf000 40110000 r-xp /usr/lib/libeina.so.1.7.99
40119000 40255000 r-xp /usr/lib/libelementary.so.1.7.99
4026c000 4033c000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
4033d000 40350000 r-xp /usr/lib/libsap-client-stub-api.so.1.0.0
40359000 403c2000 r-xp /lib/libm-2.13.so
403cb000 404ef000 r-xp /lib/libc-2.13.so
404fd000 40505000 r-xp /lib/libgcc_s-4.6.so.1
40506000 40511000 r-xp /lib/libunwind.so.8.0.1
4053e000 40540000 r-xp /lib/libdl-2.13.so
40549000 40556000 r-xp /usr/lib/libaul.so.0.1.0
40560000 40574000 r-xp /lib/libpthread-2.13.so
4057f000 40588000 r-xp /usr/lib/libvconf.so.0.2.45
40590000 405b3000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
405bb000 405c1000 r-xp /usr/lib/libappsvc.so.0.1.0
405c9000 405cc000 r-xp /usr/lib/libbundle.so.0.1.22
405d4000 405d9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
405e1000 406b4000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
406bf000 406f3000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
406fc000 40726000 r-xp /usr/lib/libsensor.so.1.9.7
4072f000 40736000 r-xp /usr/lib/libctx-shared.so.0.8.3
4073e000 40743000 r-xp /usr/lib/libctx-client.so.0.8.3
4074b000 407df000 r-xp /usr/lib/libstdc++.so.6.0.16
407f2000 407f8000 r-xp /lib/librt-2.13.so
40801000 4081a000 r-xp /usr/lib/libeet.so.1.7.99
4082b000 408f9000 r-xp /usr/lib/libevas.so.1.7.99
4091f000 40941000 r-xp /usr/lib/libecore_evas.so.1.7.99
4094a000 4094f000 r-xp /usr/lib/libecore_file.so.1.7.99
40957000 40968000 r-xp /usr/lib/libecore_input.so.1.7.99
40970000 409ce000 r-xp /usr/lib/libedje.so.1.7.99
409d8000 40a28000 r-xp /usr/lib/libecore_x.so.1.7.99
40a2a000 40a33000 r-xp /usr/lib/libedbus.so.1.7.99
40a3b000 40a65000 r-xp /usr/lib/libdbus-1.so.3.8.12
40a6e000 40a88000 r-xp /usr/lib/libecore_con.so.1.7.99
40a91000 40a99000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
40aa1000 40aa7000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
40ab0000 40ab9000 r-xp /usr/lib/libsap_client.so.0.0.0
40ac1000 40ad8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
40ae0000 40ae5000 r-xp /usr/lib/libxdgmime.so.1.1.0
40aed000 40aee000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
40af6000 40b14000 r-xp /usr/lib/libsystemd.so.0.4.0
40b1f000 40b39000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40b41000 40bb6000 r-xp /usr/lib/libsqlite3.so.0.8.6
40bc0000 40bc6000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
40bcf000 40bd1000 r-xp /usr/lib/libiniparser.so.0
40bda000 40ca6000 r-xp /usr/lib/libxml2.so.2.7.8
40cb4000 40cb5000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
40cbd000 40cc2000 r-xp /usr/lib/libffi.so.5.0.10
40cca000 40ccc000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
40cd4000 40cea000 r-xp /lib/libz.so.1.2.5
40cf2000 40d02000 r-xp /lib/libresolv-2.13.so
40d07000 40d11000 r-xp /usr/lib/libsensord-shared.so
40d1a000 40d29000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
40d32000 40d61000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40d69000 40d8c000 r-xp /usr/lib/libjpeg.so.8.0.2
40da4000 40db7000 r-xp /usr/lib/libfribidi.so.0.3.1
40dc0000 40e05000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
40e0e000 40e36000 r-xp /usr/lib/libfontconfig.so.1.8.0
40e37000 40e8d000 r-xp /usr/lib/libfreetype.so.6.11.3
40e99000 40eef000 r-xp /usr/lib/libpixman-1.so.0.28.2
40efc000 40fdd000 r-xp /usr/lib/libX11.so.6.3.0
40fe9000 40fee000 r-xp /usr/lib/libecore_fb.so.1.7.99
40ff7000 40ffb000 r-xp /usr/lib/libecore_ipc.so.1.7.99
41004000 41007000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
4100f000 41016000 r-xp /usr/lib/libembryo.so.1.7.99
4101e000 41035000 r-xp /usr/lib/liblua-5.1.so
4103f000 41045000 r-xp /usr/lib/libecore_imf.so.1.7.99
4104d000 4104e000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
41056000 4105d000 r-xp /usr/lib/libXcursor.so.1.0.2
41065000 41067000 r-xp /usr/lib/libXdamage.so.1.1.0
4106f000 41071000 r-xp /usr/lib/libXcomposite.so.1.0.0
4107a000 4107c000 r-xp /usr/lib/libXgesture.so.7.0.0
41084000 41087000 r-xp /usr/lib/libXfixes.so.3.1.0
4108f000 41098000 r-xp /usr/lib/libXi.so.6.1.0
410a0000 410a1000 r-xp /usr/lib/libXinerama.so.1.0.0
410aa000 410b0000 r-xp /usr/lib/libXrandr.so.2.2.0
410b8000 410be000 r-xp /usr/lib/libXrender.so.1.3.0
410c7000 410cb000 r-xp /usr/lib/libXtst.so.6.1.0
410d3000 410dd000 r-xp /usr/lib/libXext.so.6.4.0
410e6000 4112a000 r-xp /usr/lib/libcurl.so.4.3.0
41133000 41155000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
4115e000 41162000 r-xp /usr/lib/libsmack.so.1.0.0
4116c000 4116e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
41176000 4118e000 r-xp /usr/lib/liblzma.so.5.0.3
41196000 41198000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
411a1000 411a3000 r-xp /usr/lib/journal/libjournal.so.0.1.0
411ac000 411c9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
411d2000 411e8000 r-xp /lib/libexpat.so.1.6.0
411f2000 4120a000 r-xp /usr/lib/libpng12.so.0.50.0
41212000 41225000 r-xp /usr/lib/libxcb.so.1.1.0
4122f000 41238000 r-xp /usr/lib/libcares.so.2.1.0
41241000 4126f000 r-xp /usr/lib/libidn.so.11.5.44
41277000 412be000 r-xp /usr/lib/libssl.so.1.0.0
412ca000 4145c000 r-xp /usr/lib/libcrypto.so.1.0.0
4147d000 41484000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
4148e000 41490000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
41498000 4149f000 r-xp /usr/lib/libminizip.so.1.0.0
414a7000 414b4000 r-xp /usr/lib/libail.so.0.1.0
414bd000 41645000 r-xp /usr/lib/libicui18n.so.57.1
41655000 4175b000 r-xp /usr/lib/libicuuc.so.57.1
4300b000 43011000 r-xp /usr/lib/libproc-stat.so.0.2.96
43019000 4301a000 r-xp /usr/lib/libresponse.so.0.2.96
43022000 43024000 r-xp /usr/lib/libiri.so
4302c000 4302f000 r-xp /lib/libcap.so.2.21
43038000 4303f000 r-xp /lib/libcrypt-2.13.so
4306f000 43071000 r-xp /usr/lib/libXau.so.6.0.0
43079000 4307e000 r-xp /usr/lib/libsystem.so.0.0.0
43088000 4308b000 r-xp /lib/libattr.so.1.1.0
4319a000 43aaf000 rw-p [stack:24849]
befb8000 befd9000 rw-p [stack]
End of Maps Information

Callstack Information (PID:24828)
Call Stack Count: 19
 0: on_service_connection_created + 0xbd (0x4000215e) [/opt/usr/apps/com.urbandroid.sleep/bin/sleepasandroidnativeservice] + 0x215e
 1: sap_wrapper_service_connection_confirm_cb + 0x5c (0x40349839) [/usr/lib/libsap-client-stub-api.so.1] + 0xc839
 2: (0x40343405) [/usr/lib/libsap-client-stub-api.so.1] + 0x6405
 3: (0x40ab365f) [/usr/lib/libsap_client.so.0] + 0x365f
 4: g_simple_async_result_complete + 0x68 (0x4062dbed) [/usr/lib/libgio-2.0.so.0] + 0x4cbed
 5: (0x406649b1) [/usr/lib/libgio-2.0.so.0] + 0x839b1
 6: g_simple_async_result_complete + 0x68 (0x4062dbed) [/usr/lib/libgio-2.0.so.0] + 0x4cbed
 7: (0x4062dca1) [/usr/lib/libgio-2.0.so.0] + 0x4cca1
 8: (0x4029ffcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
 9: g_main_context_dispatch + 0xbc (0x402a17a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
10: (0x400b1ca7) [/usr/lib/libecore.so.1] + 0x10ca7
11: (0x400acb4f) [/usr/lib/libecore.so.1] + 0xbb4f
12: (0x400ad5a7) [/usr/lib/libecore.so.1] + 0xc5a7
13: ecore_main_loop_begin + 0x30 (0x400ad879) [/usr/lib/libecore.so.1] + 0xc879
14: appcore_agent_main + 0x56 (0x40053183) [/usr/lib/libappcore-agent.so.1] + 0x1183
15: service_app_main + 0x54 (0x400537fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
16: main + 0x100 (0x40002c81) [/opt/usr/apps/com.urbandroid.sleep/bin/sleepasandroidnativeservice] + 0x2c81
17: __libc_start_main + 0x114 (0x403e285c) [/lib/libc.so.6] + 0x1785c
18: (0x40001674) [/opt/usr/apps/com.urbandroid.sleep/bin/sleepasandroidnativeservice] + 0x1674
End of Call Stack

Package Information
Package Name: com.urbandroid.sleep
Package ID : com.urbandroid.sleep
Version: 1.0.8
Package Type: rpm
App Name: sleepasandroidnativeservice
App ID: com.urbandroid.sleep.service
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
0200 E/WMS     (  522): ==========
04-11 11:12:46.875+0200 E/WMS     (  522): ##WMS SEND : mgr_status_exchange_done
04-11 11:12:46.875+0200 E/WMS     (  522): ==========
04-11 11:12:46.875+0200 E/WMS     (  522): wms_msg_broker.c: wms_msg_broker_send(1842) > Data size: 73 MAX Buffer Size: 61440
04-11 11:12:46.880+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_get_device_status(879) > Host device vendor: LGE
04-11 11:12:46.890+0200 E/wnoti-service( 1082): wnoti-sap-client.c: _get_vendor_cb(3569) > vendor : LGE, vendor_type : 1
04-11 11:12:46.895+0200 I/W_INDICATOR(  765): windicator.c: windicator_is_lo_connected(976) > [windicator_is_lo_connected:976] Connected target vendor : LGE
04-11 11:12:46.900+0200 E/WG-CONSUMER(24121): [31m[F:ConnectionInfo.c L:   52][ERROR]vendor changed: db/wms/host_status/vendor:LGE[0m
04-11 11:12:46.915+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_get_device_status(894) > host mcc [230], mnc [02]
04-11 11:12:46.915+0200 E/WMS     (  522): wms_xml_util.c: wms_xml_util_get_nodeset(62) > No result
04-11 11:12:46.930+0200 E/WMS     (  522): wms_xml_util.c: wms_xml_util_get_nodeset(62) > No result
04-11 11:12:46.935+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_sync_host_status(1253) > host platform version: 6.0.1
04-11 11:12:46.960+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_sync_host_status(1441) > Host telephony feature is supported - enable call app
04-11 11:12:46.965+0200 I/W_INDICATOR(  765): windicator.c: windicator_is_lo_connected(976) > [windicator_is_lo_connected:976] Connected target vendor : LGE
04-11 11:12:46.980+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_sync_host_status(1493) > vendor[ LGE ], support.email.sync[ false ]
04-11 11:12:46.985+0200 E/PKGMGR  (  522): pkgmgr.c: pkgmgr_client_enable(2552) > enable pkg[com.samsung.call] start
04-11 11:12:47.030+0200 I/capability-manager(24844): capability_manager_util.c: is_file_exist(120) > File /opt/usr/share/wms/HostStatus.xml Exists
04-11 11:12:47.030+0200 I/capability-manager(24844): capability_manager_xml.c: capability_manager_xml_util_get_device_info(114) > capability_manager_xml_util_get_device_info() called.
04-11 11:12:47.040+0200 W/APPS    (  843): apps_main.c: apps_main_is_hide_message(1516) >  isHide[1]
04-11 11:12:47.040+0200 W/APPS    (  843): AppsItem.cpp: aniFocusIndex(2373) >  [Galaxy Apps:22] Focused[1], focusIdx[22]
04-11 11:12:47.045+0200 W/APPS    (  843): AppsItem.cpp: setLastIndex(1280) >  This is last index app [23:Sleep], focusIdx[22]
04-11 11:12:47.045+0200 W/APPS    (  843): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
04-11 11:12:47.045+0200 W/APPS    (  843): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
04-11 11:12:47.045+0200 W/wnotib  (  843): w-notification-board-broker-main.c: _wnb_wms_host_status_vendor_changed_cb(344) > vendor: LGE.
04-11 11:12:47.045+0200 I/wnotib  (  843): w-notification-board-empty-panel.c: _wnb_empty_panel_message_receive(60) > type: 15
04-11 11:12:47.050+0200 I/wnotib  (  843): w-notification-board-empty-panel.c: _wnb_ep_set_texts(348) > is_connected_vendor_LO: 0, is_standalone_mode: 0
04-11 11:12:47.060+0200 E/TIZEN_N_SYSTEM_SETTINGS(  843): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
04-11 11:12:47.060+0200 E/TIZEN_N_SYSTEM_SETTINGS(  843): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-11 11:12:47.060+0200 E/TIZEN_N_SYSTEM_SETTINGS(  843): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
04-11 11:12:47.060+0200 E/TIZEN_N_SYSTEM_SETTINGS(  843): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
04-11 11:12:47.100+0200 W/W_HOME  (  843): clock_view_indicator.c: _view_remove_by_type(267) > removed:3
04-11 11:12:47.100+0200 W/W_HOME  (  843): clock_indicator.c: clock_indicator_pop(374) > icon:3(0) is popped from clock indicator
04-11 11:12:47.100+0200 W/W_HOME  (  843): cfwd.c: cfwd_get_icon_status(362) > 
04-11 11:12:47.100+0200 W/W_HOME  (  843): ============================
04-11 11:12:47.100+0200 W/W_HOME  (  843): multi_sim_category:0
04-11 11:12:47.100+0200 W/W_HOME  (  843): multi_sim_model:0
04-11 11:12:47.100+0200 W/W_HOME  (  843): support_callforward_auto:0
04-11 11:12:47.100+0200 W/W_HOME  (  843): conn_status:1
04-11 11:12:47.100+0200 W/W_HOME  (  843): remote_call_forward_auto:0
04-11 11:12:47.100+0200 W/W_HOME  (  843): auto_call_forward_status:0
04-11 11:12:47.100+0200 W/W_HOME  (  843): support_callforward_reverse:0
04-11 11:12:47.100+0200 W/W_HOME  (  843): reverse_call_forward_auto:0
04-11 11:12:47.100+0200 W/W_HOME  (  843): fwd_type:
04-11 11:12:47.100+0200 W/W_HOME  (  843): ============================
04-11 11:12:47.100+0200 W/W_HOME  (  843): 
04-11 11:12:47.105+0200 W/W_HOME  (  843): clock_view_indicator.c: _view_call_fw_icon(136) > call fwd status:0
04-11 11:12:47.170+0200 E/CONTACTS_CONSUMER(24800): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(3594) > [0;31m* Critical * Total allocated space (uordblks):134464
04-11 11:12:47.170+0200 E/CONTACTS_CONSUMER(24800): [0;m
04-11 11:12:47.230+0200 W/WVMS_SERVER(24804): wvms-server-consumer.c: __wvoice_memo_find_peer_agent(229) > [32m Call find peer success[0m
04-11 11:12:47.235+0200 E/PKGMGR_SERVER(24851): pkgmgr-server.c: main(2242) > package manager server start
04-11 11:12:47.250+0200 W/WVMS_SERVER(24804): wvms-server-consumer.c: wvoice_memo_register_consumer(471) >  init complete
04-11 11:12:47.255+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnConnectionRequest(411) > _MessagePortIpcServer::OnConnectionRequest
04-11 11:12:47.270+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcClientConnected(172) > MessagePort Ipc connected
04-11 11:12:47.275+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnConnectionRequest(411) > _MessagePortIpcServer::OnConnectionRequest
04-11 11:12:47.290+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 11:12:47.290+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 11:12:47.290+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 11:12:47.290+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
04-11 11:12:47.290+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: RegisterMessagePort(83) > _MessagePortService::RegisterMessagePort
04-11 11:12:47.290+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 11:12:47.290+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: RegisterMessagePort(95) > Register a message port: [com.samsung.w-voicerecorder.consumer:com.samsung.voice_memo_c1_server], client = 24804
04-11 11:12:47.290+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 11:12:47.295+0200 W/WVMS_SERVER(24804): wvms-server-ipc.c: wvms_server_ipc_init(53) >  port id : [1]
04-11 11:12:47.300+0200 W/WVMS_SERVER(24804): wvms-server-consumer.c: wvoice_memo_on_peer_agent(258) >  wStatusCode : [0]
04-11 11:12:47.305+0200 W/WVMS_SERVER(24804): wvms-server-consumer.c: wvoice_memo_on_peer_agent(274) >  call create service connection
04-11 11:12:47.355+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(24793): preference.c: _preference_check_retry_err(507) > key(lockTimezone), check retry err: -21/(2/No such file or directory).
04-11 11:12:47.360+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(24793): preference.c: _preference_get_key(1101) > _preference_get_key(lockTimezone) step(-17825744) failed(2 / No such file or directory)
04-11 11:12:47.360+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(24793): preference.c: preference_get_string(1258) > preference_get_string(24793) : lockTimezone error
04-11 11:12:47.405+0200 E/CALENDAR-CONSUMER(24793): CalendarSapAgent.cpp: __isLDUBinary(1130) > [0;31m* Critical * vconf_get_int is faled.[0;m
04-11 11:12:47.455+0200 I/WSM     (  520): WSM_I [d1]
04-11 11:12:47.470+0200 E/PKGMGR_SERVER(24854): pkgmgr-server.c: queue_job(1981) > ENABLE_PKG start, pkgid=[com.samsung.call]
04-11 11:12:47.485+0200 I/efl-extension(24788): efl_extension.c: eext_mod_init(40) > Init
04-11 11:12:47.550+0200 W/SSPAY_UI_SVC(24788): sspay_ui_svc_main.c: main(292) > [36mmain start[0m
04-11 11:12:47.555+0200 E/PKGMGR  (  522): pkgmgr.c: pkgmgr_client_enable(2638) > enable pkg finish, ret=[0]
04-11 11:12:47.555+0200 E/PKGMGR  (  522): pkgmgr.c: pkgmgr_client_disable(2645) > disable pkg[com.samsung.wemail] start
04-11 11:12:47.560+0200 W/AUL_AMD (  514): amd_status.c: __socket_monitor_cb(1277) > (24788) was created
04-11 11:12:47.565+0200 W/SSPAY_UI_SVC(24788): sspay_ui_svc_main.c: _service_create(93) > [36m_service_create start[0m
04-11 11:12:47.565+0200 W/SSPAY_UI_SVC(24788): sspay_ui_svc_utils.c: sspay_ui_svc_util_get_CountryISO_with_CSC(2281) > [36mCountryISO [DE][0m
04-11 11:12:47.575+0200 E/SSPAY_UI_SVC(24788): sspay_ui_svc_app_management.c: sspay_ui_svc_am_is_retailmode_enabled(92) > [31m(ret != VCONF_OK) [0m
04-11 11:12:47.575+0200 E/SSPAY_UI_SVC(24788): sspay_ui_svc_main.c: _service_create(100) > [31mNOT ALLOWED Country!!!!!!!!!!!!!!!!![0m
04-11 11:12:47.580+0200 W/SSPAY_UI_SVC(24788): sspay_ui_svc.c: sspay_ui_svc_terminate(1712) > [36mterminate sspay-ui-svc with cpu lock during 5 sec[0m
04-11 11:12:47.580+0200 E/PKGMGR_SERVER(24855): pkgmgr-server.c: queue_job(1990) > DISABLE_PKG start, pkgid=[com.samsung.wemail]
04-11 11:12:47.585+0200 E/PKGMGR  (  522): pkgmgr.c: pkgmgr_client_disable(2731) > disable pkg finish, ret=[0]
04-11 11:12:47.600+0200 E/CAPI_TELEPHONY(  522): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-11 11:12:47.670+0200 E/PKGMGR_STATE(24854): pkg_state.c: __pkg_state_enable_pkg(339) > start enable_pkg : pkgid = com.samsung.call
04-11 11:12:47.685+0200 E/PKGMGR_STATE(24854): pkg_state.c: __make_filtered_pkgid_list(317) > pkgid[com.samsung.call] is decided not to broadcast.
04-11 11:12:47.685+0200 E/PKGMGR_STATE(24854): pkg_state.c: __pkg_state_enable_pkg(350) > nothing to broadcast.
04-11 11:12:47.715+0200 E/PKGMGR_SERVER(24851): pkgmgr-server.c: sighandler(486) > child NORMAL exit [24854]
04-11 11:12:47.730+0200 E/PKGMGR_STATE(24855): pkg_state.c: __pkg_state_disable_pkg(420) > start disable_pkg : pkgid = com.samsung.wemail
04-11 11:12:47.750+0200 E/PKGMGR_STATE(24855): pkg_state.c: __make_filtered_pkgid_list(317) > pkgid[com.samsung.wemail] is decided not to broadcast.
04-11 11:12:47.750+0200 E/PKGMGR_STATE(24855): pkg_state.c: __pkg_state_disable_pkg(431) > nothing to broadcast.
04-11 11:12:47.765+0200 E/PKGMGR_SERVER(24851): pkgmgr-server.c: sighandler(486) > child NORMAL exit [24855]
04-11 11:12:47.860+0200 I/SleepAsAndroidConsumer(24828): connectivity type(1): bt
04-11 11:12:47.900+0200 W/WVMS_SERVER(24804): wvms-server-consumer.c: wvoice_memo_on_service_connection_confirm(280) >  wResponseCode : [0]!!!
04-11 11:12:47.900+0200 W/WVMS_SERVER(24804): wvms-server-consumer.c: wvoice_memo_on_service_connection_confirm(294) > [32m service connection success[0m
04-11 11:12:47.935+0200 E/CONTACTS_CONSUMER(24800): ct-sap-svc-client.c: __on_receive(1779) > [0;31m* Critical * crypt_key for encrypt version !!![0;m
04-11 11:12:48.205+0200 W/WVMS_SERVER(24804): wvms-server-consumer.c: wvms_server_consumer_send_msg(560) >  send data success
04-11 11:12:48.245+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(505) > telephony : 0
04-11 11:12:48.245+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(506) > wifi : 1
04-11 11:12:48.245+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(510) > scs : true
04-11 11:12:48.260+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(526) > svoice not disabled
04-11 11:12:48.260+0200 E/PKGMGR_INFO(  522): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_destroy_pkginfo(1915) > (handle == NULL) pkginfo handle is NULL
04-11 11:12:48.275+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(545) > camera : 0
04-11 11:12:48.285+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(560) > wps : 1
04-11 11:12:48.295+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(566) > speaker : 0
04-11 11:12:48.305+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(572) > width : 360
04-11 11:12:48.320+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(578) > height : 360
04-11 11:12:48.330+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(584) > barometer : 1
04-11 11:12:48.340+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(590) > magnetometer : 0
04-11 11:12:48.355+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(596) > photometer : 1
04-11 11:12:48.360+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(602) > heartrate : 1
04-11 11:12:48.370+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(608) > ultraviolet : 0
04-11 11:12:48.380+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(614) > irled : 0
04-11 11:12:48.395+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(691) > push : 1
04-11 11:12:48.395+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(702) > auto connection : true
04-11 11:12:48.430+0200 E/PKGMGR_INFO(  522): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_destroy_pkginfo(1915) > (handle == NULL) pkginfo handle is NULL
04-11 11:12:48.440+0200 E/WMS     (  522): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(779) > support hfp : 0
04-11 11:12:48.440+0200 E/WMS     (  522): wms_msg_broker.c: wms_msg_broker_send(1826) > 
04-11 11:12:48.440+0200 E/WMS     (  522): ==========
04-11 11:12:48.440+0200 E/WMS     (  522): ##WMS SEND : mgr_wearable_status_res
04-11 11:12:48.440+0200 E/WMS     (  522): ==========
04-11 11:12:48.445+0200 E/WMS     (  522): wms_msg_broker.c: wms_msg_broker_send(1842) > Data size: 17073 MAX Buffer Size: 61440
04-11 11:12:48.445+0200 E/WMS     (  522): wms_event_handler.c: handle_mgr_host_status_res(17174) > need full check 0
04-11 11:12:48.445+0200 E/WMS     (  522): wms_event_handler.c: handle_mgr_host_status_res(17176) > isFirstConnect[0], is_full_sync[0]
04-11 11:12:48.445+0200 E/WMS     (  522): wms_event_handler.c: _wms_event_handler_signal_to_systemd(1216) > wmanager_connected value is already true. but rewrite.
04-11 11:12:48.445+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: _wms_connection_changed_callback(458) > [33m WMS Connected[3][0m
04-11 11:12:48.445+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_CONNECTION_CHANGED][0m
04-11 11:12:48.450+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:12:48.450+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(343) > [33m[TID:1042]   connection state = 1[0m
04-11 11:12:48.450+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[1][0m
04-11 11:12:48.450+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-mediachanged-req","value":"true"}[0m
04-11 11:12:48.455+0200 W/WPROXY  ( 1050): net-device.c: __connection_changed_cb(163) > WMS:[1], SAP:[0x1], BAP:[0]
04-11 11:12:48.455+0200 W/WPROXY  ( 1050): net-device.c: __connection_changed_cb(166) > [Ignore] Any connection status is not changed.
04-11 11:12:48.460+0200 E/W_HOME  (  843): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
04-11 11:12:48.460+0200 W/W_HOME  (  843): clock_event.c: _wmanager_connectivity_get(397) > network status : 0
04-11 11:12:48.460+0200 W/W_HOME  (  843): clock_event.c: _wmanager_connectivity_get(402) > sap_connected : 1
04-11 11:12:48.460+0200 W/W_HOME  (  843): clock_event.c: _wmanager_connectivity_get(408) > sap connectivity type : 1
04-11 11:12:48.460+0200 W/W_HOME  (  843): clock_event.c: _wmanager_connectivity_get(414) > network status : 3
04-11 11:12:48.460+0200 W/W_HOME  (  843): clock_event.c: _wmanager_connectivity_get(428) > scs login : 0
04-11 11:12:48.460+0200 W/W_HOME  (  843): clock_event.c: _wmanager_connectivity_get(470) > connected via bluetooth
04-11 11:12:48.460+0200 W/W_HOME  (  843): clock_view_indicator.c: _view_remove_by_type(267) > removed:4
04-11 11:12:48.460+0200 W/W_HOME  (  843): clock_indicator.c: clock_indicator_pop(374) > icon:5(0) is popped from clock indicator
04-11 11:12:48.460+0200 W/wnotib  (  843): w-notification-board-broker-main.c: _wnb_connection_state_changed_cb(379) > is_LO: 0, is_connected: 1
04-11 11:12:48.460+0200 E/wnotib  (  843): w-notification-board-noti-manager-common.c: wnb_nm_get_category_by_application_id(1201) > No category matched.
04-11 11:12:48.460+0200 W/wnotib  (  843): w-notification-board-broker-main.c: _wnb_connection_state_changed_cb(388) > No tips notification.
04-11 11:12:48.465+0200 W/W_INDICATOR(  765): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(1071) > [_dynamic_bluetooth_state_changed_cb:1071] isBTOn : 1
04-11 11:12:48.465+0200 W/W_INDICATOR(  765): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(1077) > [_dynamic_bluetooth_state_changed_cb:1077] sap connected : 1
04-11 11:12:48.465+0200 W/W_INDICATOR(  765): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(1083) > [_dynamic_bluetooth_state_changed_cb:1083] sap connectivity type : 1
04-11 11:12:48.465+0200 W/W_INDICATOR(  765): windicator_dynamic.c: _dynamic_event_item_pack(870) > [_dynamic_event_item_pack:870] There is NO Headset icon, so move wifi icon to position 1
04-11 11:12:48.465+0200 E/W_INDICATOR(  765): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(1097) > [_dynamic_bluetooth_state_changed_cb:1097] Failed to get moment view bt icon
04-11 11:12:48.465+0200 I/W_INDICATOR(  765): windicator.c: windicator_is_lo_connected(976) > [windicator_is_lo_connected:976] Connected target vendor : LGE
04-11 11:12:48.465+0200 W/W_INDICATOR(  765): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(1131) > [_dynamic_bluetooth_state_changed_cb:1131] display connected BT icon
04-11 11:12:48.465+0200 E/EFL     (  765): <765> elm_main.c:1622 elm_object_signal_emit() safety check failed: obj == NULL
04-11 11:12:48.465+0200 E/TIZEN_N_SYSTEM_SETTINGS(  765): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-11 11:12:48.465+0200 E/TIZEN_N_SYSTEM_SETTINGS(  765): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-11 11:12:48.465+0200 E/TIZEN_N_SYSTEM_SETTINGS(  765): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-11 11:12:48.465+0200 E/TIZEN_N_SYSTEM_SETTINGS(  765): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-11 11:12:48.475+0200 W/WECONN  (  508): <__wc_feature_wms_connected_cb:453> priv->wms_connected = 1
04-11 11:12:48.475+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:12:48.485+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 1744
04-11 11:12:48.485+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:12:48.495+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24111
04-11 11:12:48.495+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:12:48.505+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24788
04-11 11:12:48.505+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:12:48.515+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24793
04-11 11:12:48.520+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:12:48.530+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24800
04-11 11:12:48.530+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:12:48.540+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24121
04-11 11:12:48.540+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:12:48.545+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 1042
04-11 11:12:48.550+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:12:48.555+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24125
04-11 11:12:48.555+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:12:48.565+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24804
04-11 11:12:48.570+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 14
04-11 11:12:48.580+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24813
04-11 11:12:48.585+0200 I/APP_CORE(  843): appcore-efl.c: __do_app(453) > [APP 843] Event: MEM_FLUSH State: PAUSED
04-11 11:12:48.595+0200 E/wnoti-ancs( 1082): wnoti-ancs.c: wnoti_ancs_ios_connected_status(2745) > pre_connect_status : 0, bap_connected_status : 0
04-11 11:12:48.595+0200 E/WMS     (  522): wms_event_handler.c: _wms_event_handler_signal_to_systemd(1218) > 
04-11 11:12:48.595+0200 E/WMS     (  522): ==========
04-11 11:12:48.595+0200 E/WMS     (  522): ##WMS WMANAGER CONNECTED : TRUE
04-11 11:12:48.595+0200 E/WMS     (  522): ==========
04-11 11:12:48.605+0200 E/WMS     (  522): wms_event_handler.c: handle_mgr_host_status_res(17185) > TIMESTAMP saved: 1523437963076P:?LAL>AC:K:
04-11 11:12:48.605+0200 E/WMS     (  522): wms_event_handler.c: wms_event_handler_routine(24535) > [mgr_host_status_res] handler success.
04-11 11:12:48.630+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(123) > [windicator_scs_update:123] sales code : 0
04-11 11:12:48.630+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-queue-req"}[0m
04-11 11:12:48.630+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(131) > [windicator_scs_update:131] sap connected : 1
04-11 11:12:48.635+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(146) > [windicator_scs_update:146] ciss_request_type : 0
04-11 11:12:48.635+0200 I/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(155) > [windicator_scs_update:155] Hide (Callforwarding requested)
04-11 11:12:48.635+0200 I/W_INDICATOR(  765): windicator.c: windicator_is_lo_connected(976) > [windicator_is_lo_connected:976] Connected target vendor : LGE
04-11 11:12:48.635+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(195) > [windicator_scs_update:195] sap connectivity type : 1
04-11 11:12:48.635+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(203) > [windicator_scs_update:203] network status : 3
04-11 11:12:48.635+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(220) > [windicator_scs_update:220] scs login : 0
04-11 11:12:48.640+0200 W/W_INDICATOR(  765): windicator_scs.c: windicator_scs_update(261) > [windicator_scs_update:261] connected via bluetooth
04-11 11:12:48.650+0200 W/MSG_CONSUMER( 1407): SapClient.cpp: _onWmsConnectionChanged(810) > [0;35mprevious_status: (1), status: (1)[0;m
04-11 11:12:48.650+0200 W/WG-CONSUMER(24121): [32m[F:SAPProxy.cpp     L:  621][_WARN]_on_wms_connected_changed, value = 1, key = memory/wms/wmanager_connected[0m
04-11 11:12:48.655+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  601][_HIGH]Device Connected. Cur type=BT|[0m
04-11 11:12:48.655+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  633][_HIGH]WMS status changed. VConf memory/wms/wmanager_connected value=1 BT=1[0m
04-11 11:12:48.655+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  637][_HIGH]WMS is connected. Try to connection. Connections=2[0m
04-11 11:12:48.655+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  190][_HIGH][TX]CConnection::Connect() State:SM_STATE_ESTABLISHED[0m
04-11 11:12:48.655+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  147][_HIGH]CSAPProxy::Connect. Size=2 pConnection=0x4332bc00[0m
04-11 11:12:48.655+0200 W/MSG_CONSUMER( 1407): SapClient.cpp: _onWmsConnectionChanged(813) > [0;35m_onWmsConnectionChanged() is ignored for same status change. prev:(1), cur:(1)[0;m
04-11 11:12:48.655+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  150][_HIGH]  Connection : [TX] LocalAgentID:60919 ServiceHandle:64016[0m
04-11 11:12:48.660+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  150][_HIGH]  Connection : [RX] LocalAgentID:60920 ServiceHandle:28390[0m
04-11 11:12:48.660+0200 E/WG-CONSUMER(24121): [31m[F:SAPProxy.cpp     L:  161][ERROR]Duplication connection. not inseterd[0m
04-11 11:12:48.660+0200 E/WG-CONSUMER(24121): [31m[F:SAPProxy.cpp     L:  165][ERROR]Previous pCurrent(0x43308370) is exist[0m
04-11 11:12:48.660+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  601][_HIGH]Device Connected. Cur type=BT|[0m
04-11 11:12:48.665+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  186][_HIGH]Device connected. WMS=1 BT=1 [0m
04-11 11:12:48.665+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  568][_HIGH][TX]advance. CurState=SM_STATE_ESTABLISHED(8)[0m
04-11 11:12:48.665+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  590][_HIGH]Already established.[0m
04-11 11:12:48.665+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  190][_HIGH][RX]CConnection::Connect() State:SM_STATE_ESTABLISHED[0m
04-11 11:12:48.665+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  147][_HIGH]CSAPProxy::Connect. Size=2 pConnection=0x43308370[0m
04-11 11:12:48.665+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  150][_HIGH]  Connection : [TX] LocalAgentID:60919 ServiceHandle:64016[0m
04-11 11:12:48.665+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  150][_HIGH]  Connection : [RX] LocalAgentID:60920 ServiceHandle:28390[0m
04-11 11:12:48.670+0200 E/WG-CONSUMER(24121): [31m[F:SAPProxy.cpp     L:  161][ERROR]Duplication connection. not inseterd[0m
04-11 11:12:48.670+0200 E/WG-CONSUMER(24121): [31m[F:SAPProxy.cpp     L:  165][ERROR]Previous pCurrent(0x4332bc00) is exist[0m
04-11 11:12:48.670+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  601][_HIGH]Device Connected. Cur type=BT|[0m
04-11 11:12:48.670+0200 W/WG-CONSUMER(24121): [34m[F:SAPProxy.cpp     L:  186][_HIGH]Device connected. WMS=1 BT=1 [0m
04-11 11:12:48.670+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  568][_HIGH][RX]advance. CurState=SM_STATE_ESTABLISHED(8)[0m
04-11 11:12:48.670+0200 W/WG-CONSUMER(24121): [34m[F:ConnectionInfo.c L:  590][_HIGH]Already established.[0m
04-11 11:12:48.725+0200 E/weather-consumer(24813): SAP.cpp: CreateService(126) > [0;40;31mSAP::CreateService[0;m
04-11 11:12:48.775+0200 I/efl-extension(24836): efl_extension.c: eext_mod_init(40) > Init
04-11 11:12:48.800+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-getattribute-req"}[0m
04-11 11:12:48.885+0200 E/WMS     (  522): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
04-11 11:12:48.900+0200 I/UXT     (24836): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
04-11 11:12:48.975+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_CAPABILITY_FEATURE_RESPONSE][0m
04-11 11:12:48.975+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:12:48.975+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[0][0m
04-11 11:12:48.975+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: wmc_service_consumer_send_data(598) > [33m {"msgId":"music-mediachanged-req","value":"false"}[0m
04-11 11:12:49.160+0200 I/magazine-service(  995): magazine-service-connection.c: _magazine_service_connection_vconf_key_changed_cb(183) > host_connected changed [1] -> [1]
04-11 11:12:49.165+0200 E/WMS     (  522): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
04-11 11:12:49.355+0200 I/AUL_PAD (24836): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
04-11 11:12:49.390+0200 E/MALI    (24836): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
04-11 11:12:49.390+0200 E/MALI    (24836): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
04-11 11:12:49.390+0200 E/MALI    (24836): [gpu-ddk] devel/graphics_drv/r4p0
04-11 11:12:49.390+0200 E/MALI    (24836): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
04-11 11:12:49.390+0200 E/MALI    (24836): [coregl] devel/graphics_engine/master
04-11 11:12:49.390+0200 E/MALI    (24836): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
04-11 11:12:49.390+0200 E/MALI    (24836): CHK!\
04-11 11:12:49.580+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(381) > [33m[TID:1042]   distinct state = 0, max vol[15], safety_vol[0][0m
04-11 11:12:49.585+0200 W/MUSIC_PLAYER( 1042): mp-weconn.c: _wms_connection_vconf_changed_callback(93) > [33m[TID:1042]   [1][0m
04-11 11:12:49.585+0200 W/MC_CONSUMER( 1042): wmc-service-cotroller.c: _bt_connection_changed_cb(60) > [33m connected[1][0m
04-11 11:12:49.655+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [64][{"msgId":"music-mediachanged-rsp","result":"success","reason":0}][0m
04-11 11:12:49.660+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [142][{"msgId":"music-mediachanged-ind","artist":"","album":"","title":"","audioId":"-1","playStatus":"false","favoriteStatus":"false","index":"-1"}][0m
04-11 11:12:49.660+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_MEDIA_CHANGED_IND][0m
04-11 11:12:49.660+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:12:49.660+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[0][0m
04-11 11:12:49.665+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [44][{"msgId":"music-queuechanged-ind","count":0}][0m
04-11 11:12:49.665+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_QUEUE_CHANGED_IND][0m
04-11 11:12:49.665+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:12:49.670+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[0][0m
04-11 11:12:49.670+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [81][{"msgId":"music-playstatechange-rsp","result":"success","reason":0,"playstate":2}][0m
04-11 11:12:49.675+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_PLAY_STATE_CHANGE_RESPONSE][0m
04-11 11:12:49.675+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:12:49.675+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[0][0m
04-11 11:12:49.675+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(393) > [33m[TID:1042]   player state = 2[0m
04-11 11:12:49.675+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-info.c: music_control_info_set_player_state(423) > [33m[TID:1042]   mode = [1], player state = [0][0m
04-11 11:12:49.675+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-media-controller.c: music_control_media_controller_set_playback_state(74) > [33m[TID:1042]   state[2], 1:playing[0m
04-11 11:12:49.675+0200 W/CAPI_MEDIA_CONTROLLER( 1042): media_controller_server.c: mc_server_set_playback_state(284) > [0m<Enter>
04-11 11:12:49.675+0200 W/CAPI_MEDIA_CONTROLLER( 1042): media_controller_server.c: mc_server_set_playback_state(290) > [0mplayback state update [2]
04-11 11:12:49.675+0200 W/CAPI_MEDIA_CONTROLLER( 1042): media_controller_server.c: mc_server_set_playback_state(295) > [0m<Leave>
04-11 11:12:49.680+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-media-controller.c: music_control_media_controller_update_playback_info(138) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]update playback info[0m
04-11 11:12:49.685+0200 W/CAPI_MEDIA_CONTROLLER( 1042): media_controller_server.c: mc_server_update_playback_info(326) > [0m<Enter>
04-11 11:12:49.685+0200 W/CAPI_MEDIA_CONTROLLER( 1042): media_controller_server.c: mc_server_update_playback_info(331) > [0mplayback info update: state [2], position [0]
04-11 11:12:49.690+0200 W/CAPI_MEDIA_CONTROLLER( 1042): media_controller_server.c: mc_server_update_playback_info(353) > [0m<Leave>
04-11 11:12:49.690+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT][0m
04-11 11:12:49.690+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [37][{"msgId":"music-queue-rsp","count":0}][0m
04-11 11:12:49.695+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_QUEUE_RSP][0m
04-11 11:12:49.695+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:12:49.695+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[0][0m
04-11 11:12:49.695+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [129][{"msgId":"music-getattribute-rsp","result":"failure","reason":0,"repeat":"repeatoff","shuffle":"off","volume":13,"earjack":false}][0m
04-11 11:12:49.695+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1042]   msg [WMC_SERVICE_WIPC_MSG_ID_GET_ATTRIBUTE_RESPONSE][0m
04-11 11:12:49.695+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(243) > [36m[TID:1042]   [MUSIC_PLAYER_EVENT]Device State [2] normal:0 dim:1 off:2[0m
04-11 11:12:49.695+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1042]   remote mode[1],resume[0][0m
04-11 11:12:49.695+0200 W/MUSIC_CONTROL_SERVICE( 1042): music-control-consumer-control.c: music_control_consumer_msg_process(330) > [33m[TID:1042]   volume = 13, earjack = 0[0m
04-11 11:12:49.715+0200 W/MC_CONSUMER( 1042): wmc-service-consumer.c: __wmc_on_data_ind(386) > [33m length : [64][{"msgId":"music-mediachanged-rsp","result":"success","reason":0}][0m
04-11 11:12:49.725+0200 W/W_INDICATOR(  765): windicator_ongoing_info_music.c: _player_playback_updated_cb(134) > [_player_playback_updated_cb:134] Playback is updated. [com.samsung.w-music-player.music-control-service][2]
04-11 11:12:49.740+0200 I/SleepAsAndroidConsumer(24828): agent is initialized
04-11 11:12:49.745+0200 D/SleepAsAndroidConsumer(24828): find peer called
04-11 11:12:49.750+0200 I/SleepAsAndroidConsumer(24828): agent initialized callback is over
04-11 11:12:49.750+0200 D/SleepAsAndroidConsumer(24828): SAP >>> getRegisteredServiceAgent() >>> 0
04-11 11:12:49.780+0200 I/CAPI_APPFW_APPLICATION(24788): service_app_main.c: service_app_exit(441) > service_app_exit
04-11 11:12:49.820+0200 E/CAPI_APPFW_APPLICATION(24788): service_app_error.c: service_app_error(63) > [_service_app_create] INVALID_CONTEXT(0xfef00001) : service_app_create_cb() returns false
04-11 11:12:49.835+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 22
04-11 11:12:49.835+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(999) > app status : 4
04-11 11:12:49.835+0200 W/SSPAY_UI_SVC(24788): sspay_ui_svc_main.c: _service_terminate(129) > [36m_service_terminate start[0m
04-11 11:12:49.835+0200 W/SSPAY_UI_SVC(24788): sspay_ui_svc_main.c: _service_terminate(135) > [36m_service_terminate end[0m
04-11 11:12:49.905+0200 E/AUL_PAD ( 1323): launchpad.c: main(892) > Refused candidate process connection
04-11 11:12:49.905+0200 E/AUL     (24836): process_pool.c: __connect_to_launchpad(148) > send error
04-11 11:12:49.910+0200 I/efl-extension(24836): efl_extension.c: eext_mod_shutdown(46) > Shutdown
04-11 11:12:49.925+0200 I/MALI    (24836): egl_platform_x11.c: __egl_platform_terminate(324) > [EGL-X11] ################################################
04-11 11:12:49.925+0200 I/MALI    (24836): egl_platform_x11.c: __egl_platform_terminate(325) > [EGL-X11] PID=24836   close drm_fd=23 
04-11 11:12:49.925+0200 I/MALI    (24836): egl_platform_x11.c: __egl_platform_terminate(326) > [EGL-X11] ################################################
04-11 11:12:49.950+0200 I/efl-extension(24788): efl_extension.c: eext_mod_shutdown(46) > Shutdown
04-11 11:12:49.990+0200 E/PKGMGR_SERVER(24851): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
04-11 11:12:49.990+0200 E/PKGMGR_SERVER(24851): pkgmgr-server.c: main(2296) > package manager server terminated.
04-11 11:12:49.995+0200 D/SleepAsAndroidConsumer(24828): find peer call succeeded
04-11 11:12:50.020+0200 W/AUL_PAD ( 1323): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 24836 pgid = 24836
04-11 11:12:50.020+0200 W/AUL_PAD ( 1323): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 255
04-11 11:12:50.025+0200 E/CAPI_APPFW_APP_CONTROL(24793): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : failed to retrieve the appid of the caller
04-11 11:12:50.025+0200 W/CAPI_APPFW_APP_CONTROL(24793): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 11:12:50.025+0200 W/CAPI_APPFW_APP_CONTROL(24793): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-11 11:12:50.025+0200 E/CAPI_APPFW_APP_CONTROL(24793): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : failed to retrieve the appid of the caller
04-11 11:12:50.145+0200 W/AUL_PAD ( 1323): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
04-11 11:12:50.175+0200 I/AUL_AMD (  514): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 24836
04-11 11:12:50.175+0200 W/AUL     (  514): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(24836)
04-11 11:12:50.205+0200 E/RESOURCED(  623): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/24788/oom_score_adj failed
04-11 11:12:50.205+0200 E/RESOURCED(  623): proc-main.c: resourced_proc_status_change(1501) > Empty pid or process not exists. 24788
04-11 11:12:50.215+0200 D/SleepAsAndroidConsumer(24828): find peer call is over
04-11 11:12:50.215+0200 I/SleepAsAndroidConsumer(24828): Find Peer Success!!
04-11 11:12:50.215+0200 D/SleepAsAndroidConsumer(24828): request_service_connection call over
04-11 11:12:50.215+0200 D/SleepAsAndroidConsumer(24828): req service conn call succeeded
04-11 11:12:50.220+0200 E/CONTACTS_CONSUMER(24800): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(3594) > [0;31m* Critical * Total allocated space (uordblks):139472
04-11 11:12:50.220+0200 E/CONTACTS_CONSUMER(24800): [0;m
04-11 11:12:50.230+0200 E/CONTACTS_CONSUMER(24800): ct-sap-svc-main.c: __service_check_vendor_init(138) > [0;31m* Critical * ios_connected:0[0;m
04-11 11:12:50.230+0200 E/CONTACTS_CONSUMER(24800): ct-sap-svc-client.c: ct_sap_svc_client_init(4449) > [0;31m* Critical * contacts_db_add_changed_cb() Failed(-22)[0;m
04-11 11:12:50.230+0200 E/CONTACTS_CONSUMER(24800): ct-sap-svc-client.c: __ct_sap_svc_client_intialize_sap_connection(418) > [0;31m* Critical * consumer is alreay initialized[0;m
04-11 11:12:50.240+0200 W/AUL     (24861): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.samsung-pay-app-service]
04-11 11:12:50.240+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(669) > __request_handler: 23
04-11 11:12:50.240+0200 W/AUL_AMD (  514): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-11 11:12:50.240+0200 W/AUL_AMD (  514): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 24365
04-11 11:12:50.240+0200 W/AUL_AMD (  514): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-11 11:12:50.255+0200 E/CONTACTS_CONSUMER(24800): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(3594) > [0;31m* Critical * Total allocated space (uordblks):139856
04-11 11:12:50.255+0200 E/CONTACTS_CONSUMER(24800): [0;m
04-11 11:12:50.265+0200 E/CONTACTS_CONSUMER(24800): ct-sap-svc-parser-contacts.c: ct_sap_svc_parser_contacts_get_feature_info(3669) > [0;31m* Critical * ##FEATURE##:  supportLog(0)[0;m
04-11 11:12:50.265+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-11 11:12:50.265+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-11 11:12:50.265+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-11 11:12:50.265+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-11 11:12:50.265+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-11 11:12:50.265+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-11 11:12:50.265+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.message.consumer:com.samsung.message.consumer]
04-11 11:12:50.265+0200 E/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(347) > _MessagePortService::SendMessage: Failed :MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
04-11 11:12:50.265+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-11 11:12:50.270+0200 I/AUL_AMD (  514): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 24365
04-11 11:12:50.270+0200 W/AUL     (  514): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(24365)
04-11 11:12:50.275+0200 E/MESSAGE_PORT(24800): MessagePortProxy.cpp: SendMessageInternal(533) > The remote message port is not found.
04-11 11:12:50.275+0200 E/CONTACTS_CONSUMER(24800): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(3594) > [0;31m* Critical * Total allocated space (uordblks):145848
04-11 11:12:50.275+0200 E/CONTACTS_CONSUMER(24800): [0;m
04-11 11:12:50.370+0200 W/MM_CAMCORDER(24778): mm_camcorder_internal.c: _mmcamcorder_constructor(203) >  start
04-11 11:12:50.375+0200 W/MM_CAMCORDER(24778): mm_camcorder_internal.c: _mmcamcorder_constructor(213) >  done
04-11 11:12:50.390+0200 I/efl-extension(24778): efl_extension.c: eext_mod_init(40) > Init
04-11 11:12:50.455+0200 I/SleepAsAndroidConsumer(24828): peer agent connection is successful, pa :1124852296
04-11 11:12:50.565+0200 E/weather-consumer(24813): WeatherConsumerController.cpp: Start(73) > [0;40;31mhostDeviceVendor : LGE[0;m
04-11 11:12:50.565+0200 E/weather-consumer(24813): AppcessoryProtocol.cpp: SetSendMessageType(60) > [0;40;31mSetSendMessageType : 0[0;m
04-11 11:12:50.565+0200 E/weather-consumer(24813): AppcessoryProtocol.cpp: MakeMessageForAndroid(88) > [0;40;31mMakeMessageForAndroid[0;m
04-11 11:12:50.565+0200 E/weather-consumer(24813): AppcessoryProtocol.cpp: CreateCpListText(160) > [0;40;31mCP list supported : "Accuweather","TWC","WeatherNews","cmaweather","Kweather","WCN"[0;m
04-11 11:12:50.565+0200 E/weather-consumer(24813): AppcessoryProtocol.cpp: MakeMessageForAndroid(140) > [0;40;31mmSendMessage : {"WEATHER_REQUEST":{"FETCH_REQ":1,"SHOW_SETTING_ON_DEVICE":0,"UPDATED_BY_GEAR":0,"CP_LIST":["Accuweather","TWC","WeatherNews","cmaweather","Kweather","WCN"],"ADD_CURRENT_CITY":0},"REVISION":1,"WEATHER_ACK_SEQ": "1523437970"}[0;m
04-11 11:12:50.565+0200 E/weather-consumer(24813): SAP.cpp: InitializeSAPConnection(142) > [0;40;31mSAP::InitializeSAPConnection[0;m
04-11 11:12:50.565+0200 E/weather-consumer(24813): SAP.cpp: CreateService(126) > [0;40;31mSAP::CreateService[0;m
04-11 11:12:50.625+0200 E/CONTACTS_CONSUMER(24800): ct-sap-svc-client.c: __ct_sap_svc_client_find_peer_agent(1180) > [0;31m* Critical * connectivity_type 1[0;m
04-11 11:12:50.660+0200 E/weather-consumer(24813): SAPNotificationCallback.cpp: OnRegisterServiceAgentConfirm(35) > [0;40;31mAlready Registered uwLocalAgentId, 60924 : 60924[0;m
04-11 11:12:50.790+0200 E/weather-consumer(24813): WeatherConsumerController.cpp: OnAppcessoryProtocolConnected(134) > [0;40;31mOnAppcessoryProtocolConnected[0;m
04-11 11:12:50.795+0200 E/CAPI_APPFW_APPLICATION_ALARM(24793): alarm.c: convert_error_code_to_alarm(77) > [alarm_cancel] INVALID_PARAMETER(0xffffffea)
04-11 11:12:50.965+0200 W/CONTACTS_CONSUMER(24800): ct-sap-svc-client.c: __ct_sap_svc_client_set_logs_sync_status(1220) > [0;35mlogs_sync_status on reconnection: (3) -> (1)[0;m
04-11 11:12:50.965+0200 E/CONTACTS_CONSUMER(24800): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(3594) > [0;31m* Critical * Total allocated space (uordblks):145720
04-11 11:12:50.965+0200 E/CONTACTS_CONSUMER(24800): [0;m
04-11 11:12:51.000+0200 W/CONTACTS_CONSUMER(24800): ct-sap-svc-client.c: __on_create(2490) > [0;35mis_connected_by_scs 0[0;m
04-11 11:12:51.000+0200 E/CONTACTS_CONSUMER(24800): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(3594) > [0;31m* Critical * Total allocated space (uordblks):145736
04-11 11:12:51.000+0200 E/CONTACTS_CONSUMER(24800): [0;m
04-11 11:12:51.040+0200 W/WVMS_SERVER(24804): wvoice-memo-media-info.c: wvoice_memo_media_get_next_unsync(331) > [32m no unsync file[0m
04-11 11:12:51.040+0200 W/WVMS_SERVER(24804): wvms-server-controller.c: wvms_server_controller_send_file_process(193) > [32m transfer file is not existed[0m
04-11 11:12:51.220+0200 W/CRASH_MANAGER(24862): worker.c: worker_job(1205) > 1124828736c65152343797
