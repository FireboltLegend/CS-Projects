-- Code your design here
library IEEE;
use IEEE.std_logic_1164.all;

entity xorGate is
	port(a : in STD_LOGIC_VECTOR(3 downto 0);
    	 y : out STD_LOGIC);
end xorGate;

architecture synth of xorGate is
begin
	process(a)
    begin
    	y <= a(3) xor a(2) xor a(1) xor a(0);
	end process;
end synth;