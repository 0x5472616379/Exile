namespace Exile.Constants;

public enum ServerOpCodes377 : byte
{
                               // 377 Names
    FLOORITEM_REMOVE = 208,    // REMOVE_GROUND_ITEM
    ITEM_SET = 107,            // SET_GROUND_ITEM
    
    OBJ_REMOVE = 88,           // REMOVE_LANDSCAPE_OBJECT
    OBJ_ADD = 152,             // SET_LANDSCAPE_OBJECT
    
    ANIM_ALL_RESET = 13,       // RESET_MOB_ANIMATIONS
    ANIM_SET = 2,              // SET_WIDGET_ANIMATION
    
    SONG_PLAY = 220,           // PLAY_SONG
    SONG_QUEUE = 249,          // PLAY_TEMP_SONG
    SOUND_PLAY = 26,           // PLAY_SOUND
    SOUND_PLAYAT = 41,         // PLAY_POSITION_SOUND
    
    INTF_INV_HUD = 219,        // CLEAR_WIDGET_ITEMS
    INTF_HIDDEN = 82,          // HIDE_WIDGET
    INTF_MODEL_SET = 162,      // SET_WIDGET_MODEL_2
    INTF_SCROLL_SET = 200,     // UPDATE_WIDGET_SCROLL_POSITION
    
    PLAYER_UPDATE = 90,        // PLAYER_UPDATING
    PLAYER_RUN_ENERGY = 125,   // UPDATE_RUN_ENERGY
    PLAYER_WEIGHT = 174,       // UPDATE_CARRY_WEIGHT
    
    CHAT_SETTINGS = 201,       // UPDATE_CHAT_SETTINGS
    
    NPC_UPDATE = 71,           // NPC_UPDATING
    NPC_ICON = 199,            // SHOW_HINT_ICON
    SYSTEM_UPDATE_SECS = 190,  // SYSTEM_UPDATE
    
    REGION_LOAD = 222,         // UPDATE_ACTIVE_MAP_REGION
    MSG_SEND = 63,             // SEND_MESSAGE
    INTF_WELCOME = 76          // UPDATE_WELCOME_SCREEN
}