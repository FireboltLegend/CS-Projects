-- Code your design here
library IEEE;
use IEEE.std_logic_1164.all;

entity traffic is
	port(clk, reset, Ta, Tb : in STD_LOGIC;
         La, Lb : out STD_LOGIC_VECTOR(1 downto 0));
end traffic;

architecture synth of traffic is
  type statetype is (S0, S1, S2, S3);
  signal state, nextState: statetype;
begin
	process(clk, reset, Ta, Tb)
    begin
    	if reset = '1' then state <= S0;
		elsif rising_edge(clk) then
            state <= nextState;
		end if;
    end process;
	
    nextstate <= S1 when state = S0 and Ta = '0' else
				 S0 when state = S0 and Ta = '1' else
				 S2 when state = S1 else
                 S3 when state = S2 and Tb = '0' else
                 S2 when state = S2 and Tb = '1' else
                 S0 when state = S3;
    
    La <= "00" when state = S0 else
    	  "01" when state = S1 else
          "10";
    Lb <= "00" when state = S2 else
    	  "01" when state = S3 else
          "10";
end synth;