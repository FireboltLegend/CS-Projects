-- Code your testbench here
library IEEE;
use IEEE.STD_LOGIC_1164.ALL;
use IEEE.STD_LOGIC_TEXTIO.ALL;
use STD.TEXTIO.all;

entity testXorGate is
end testXorGate;

architecture testArch of testXorGate is
    component xorGate
        port(a : in STD_LOGIC_VECTOR(3 downto 0);
        	 y : out STD_LOGIC);
    end component;
    signal a : STD_LOGIC_VECTOR(3 downto 0);
    signal y : STD_LOGIC;
    signal y_expected: STD_LOGIC;
    signal clk : STD_LOGIC;

begin
    dut : xorGate port map(a, y);
    process begin
        clk <= '1'; wait for 5ns;
        clk <= '0'; wait for 5ns;
    end process;
    process is
      file tv : text;
      variable L : line;
      variable vector_in : std_logic_vector(3 downto 0);
      variable dummy : character;
      variable vector_out : std_logic;
      variable vectornum : integer := 0;
      variable errors : integer := 0;
    begin
      FILE_OPEN(tv, "example.tv", READ_MODE);
      while not endfile(tv) loop
      	wait until rising_edge(clk);
        readline(tv, L);
        read(L, vector_in);
        read(L, dummy);
        read(L, vector_out);
        a <= vector_in(3 downto 0);
        y_expected <= vector_out;
        wait until falling_edge(clk);
        if y /= y_expected then
          report "At a = " & to_string(a) & " Error: XOR Gate Output y = " & std_logic'image(y) & " And example.tv y_expected = " & std_logic'image(y_expected);
          errors := errors + 1;
        end if;
          vectornum := vectornum + 1;
      end loop;
      if (errors = 0) then
      	report "NO ERRORS -- " &
        integer'image(vectornum) &
        " tests completed successfully."
        severity failure;
      else
      	report integer'image(vectornum) &
        " tests completed, errors = " &
        integer'image(errors)
        severity failure;
        end if;
    end process;
end testArch;