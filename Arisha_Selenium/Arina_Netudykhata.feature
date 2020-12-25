Feature: testing feedback, word search, brand links, careers navigation, team joining, logo click-backing, language changing

Scenario: Checking Feedback functionality
   Given the user navigates to https://www.epam.com/ 
   When the user clicks on Contact us, then Contact us page opens
   And the user submits feedback message
   Then feedback should be received on the admin page
   And admin can reply to user

Scenario: Successful search of words
   Given the user navigates to https://www.epam.com/
   When the user clicks on Search, Search pop-up opens
   And type special word to find in field
   And clicks Find
   Then the Search page should open
   And search results should be given

Scenario Outline: Epam brands linking
   Given the user navigates to https://www.epam.com/
   When the user scrolls to the end of page
   Then the user should see Epam "<brands>" navigation
   When the user clicks on "<brands>"
   Then "<brand-page>" should opens

Examples:
      |brands          |brand-page                           | 
      | EPAM CONTINUUM | https://www.epam.com/epam-continuum |
      | TELESCOPEAI    |        https://www.telescopeai.com/ |
      | INFOGEN        |           https://www.infongen.com/ |
      | CYBER R&D LAB  |          https://www.cyberdlab.com/ |

Scenario: Failed search of some words
   Given the user navigates to https://www.epam.com/
   When the user clicks on Search, Search pop-up opens
   And type fail word to find in field
   And clicks Find
   Then the Search page should open
   And "Sorry, but your search returned no results. Please try another query." message should be given

Scenario Outline: Careers navigation checking
   Given the user navigates to https://www.epam.com/
   When the user moves cursor to "Careers"
   Then the user should see the "<navigation>" options

Examples:
       |navigation          |
       |JOIN OUR TEAM       |
       |EPAM WITHOUT BORDERS|
       |REFERRAL PROGRAM    |
       |BLOG                |

Scenario: Join EPAM Team checker
   Given the user navigates to https://www.epam.com/
   When the user moves cursor to "Careers"
   And the user clicks on "JOIN OUR TEAM", join page opens
   And the user click Apply, apply page opens
   And the user fill the fields
   And the user clicks Submit
   Then thanks-submitting message shows
   And submition should be received on the admin page
   And admin can reply to user

Scenario: Logo click-backing to start page
   Given the user click on navigation tools
   And internal pages has opened
   When the user clicks on Logo
   Then the user navigates to https://www.epam.com/

Scenario Outline: Language change
   Given the user navigates to https://www.epam.com/
   When the user clicks on "Global (EN)"
   Then "Select region and language" pop-up shows
   And the user should see the following "<language>"
   When the user clicks on "<language>"
   Then site version should opens
       
Examples:  
       |language               |
       |Global (English)       |
       |Czec Repablic (English)|
       |Czec Repablic (Czec)   |
       |Hungary (English)      |
       |India (English)        |
       |Polska (Polski)        |
       |Ukraine (English)      |
       |China (China)          |
       |Belarus (Russian)      |
       |Russia (Russian)       |